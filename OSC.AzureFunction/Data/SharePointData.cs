using Microsoft.SharePoint.Client;
using OSC.AzureFunction.Model;
using OSC.AzureFunction.Service;
using PnP.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace OSC.AzureFunction.Data
{
    public class SharePointData
    {
        public static List<SharePointModel> GetBynaryFilesFroSharePoint(string siteURL, string appId, string appSecret, string list)
        {
            List<SharePointModel> fileList = new List<SharePointModel>();
            using (var context = new AuthenticationManager().GetACSAppOnlyContext(siteURL, appId, appSecret))
            {
                context.Load(context.Web, p => p.Title);
                context.ExecuteQuery();
                var files = context.Web.GetFolderByServerRelativeUrl($"{siteURL}/{list}").Files;

                context.Load(files);
                context.ExecuteQuery();

                foreach (Microsoft.SharePoint.Client.File file in files)
                {
                    ClientResult<System.IO.Stream> data = file.OpenBinaryStream();
                    context.Load(file);
                    context.ExecuteQuery();
                    using (System.IO.MemoryStream mStream = new System.IO.MemoryStream())
                    {
                        if (data != null)
                        {
                            data.Value.CopyTo(mStream);
                            byte[] imageArray = mStream.ToArray();
                            string b64String = Convert.ToBase64String(imageArray);

                            fileList.Add(new SharePointModel(file, imageArray));
                        }
                    }
                }
            }
            return fileList;
        }
        public static void CreateSHA512FileInSharePoint(string siteURL, string appId, string appSecret, string mainFolder, string list, List<SharePointModel> listSharePointModel)
        {
            using (var context = new AuthenticationManager().GetACSAppOnlyContext(siteURL, appId, appSecret))
            {
                foreach (var sharePointModel in listSharePointModel)
                {
                    string SHA512Value = Checksum.GetSHA512FileString(sharePointModel.binaryFileValue);

                    FileCreationInformation createFile = new FileCreationInformation();
                    createFile.Url = $"{sharePointModel.File.Name}.SHA512";

                    string content = SHA512Value;
                    byte[] toBytes = Encoding.ASCII.GetBytes(content);
                    createFile.Content = toBytes;

                    Folder checksumFolder = null;
                    checksumFolder = CreateSubFolder(context, siteURL, mainFolder, list);

                    // ENSURE THAT TARGET LIBRARY EXISTS, CREATE IF IS MISSING
                    //if (!LibraryExists(context, context.Web, list))
                    //    CreateLibrary(context, context.Web, list);

                    //List List = context.Web.Lists.GetByTitle(list);
                    //Microsoft.SharePoint.Client.File uploadFile = List.RootFolder.Files.Add(createFile);

                    Microsoft.SharePoint.Client.File uploadFile = checksumFolder.Files.Add(createFile);

                    context.Load(uploadFile);
                    context.ExecuteQuery();

                    // LARGE FILES METHOD
                    //new FileUploadService().UploadFileSlicePerSlice(context, list, uploadFile, 1);
                }
            }
        }
        public static void CreateXFDLFileInSharePoint(string siteURL, string appId, string appSecret, string list, XmlDocument XFDLFile, string fileName)
        {
            using (var context = new AuthenticationManager().GetACSAppOnlyContext(siteURL, appId, appSecret))
            {
                FileCreationInformation createFile = new FileCreationInformation();
                createFile.Url = $"Files/{fileName}.xfdl";

                string content = XFDLFile.OuterXml;
                byte[] toBytes = Encoding.Default.GetBytes(XFDLFile.OuterXml);
                createFile.Content = toBytes;

                // ENSURE THAT TARGET LIBRARY EXISTS, CREATE IF IS MISSING
                if (!LibraryExists(context, context.Web, list))
                    CreateLibrary(context, context.Web, list);

                List List = context.Web.Lists.GetByTitle(list);
                Microsoft.SharePoint.Client.File uploadFile = List.RootFolder.Files.Add(createFile);

                context.Load(uploadFile);
                context.ExecuteQuery();
            }
        }
        private static void CreateLibrary(ClientContext ctx, Web web, string libraryName)
        {
            // Create library to the web
            ListCreationInformation creationInfo = new ListCreationInformation();
            creationInfo.Title = libraryName;
            creationInfo.TemplateType = (int)ListTemplateType.DocumentLibrary;
            List list = web.Lists.Add(creationInfo);
            ctx.ExecuteQuery();
        }
        private static bool LibraryExists(ClientContext ctx, Web web, string libraryName)
        {
            ListCollection lists = web.Lists;
            IEnumerable<List> results = ctx.LoadQuery<List>(lists.Where(list => list.Title == libraryName));
            ctx.ExecuteQuery();
            List existingList = results.FirstOrDefault();

            if (existingList != null)
            {
                return true;
            }

            return false;
        }
        private static Folder CreateSubFolder(ClientContext context, string siteURL, string mainFolder, string folder)
        {
            Web web = context.Web;
            var folders = context.Web.GetFolderByServerRelativeUrl($"{siteURL}").Folders;
            context.Load(folders);
            context.ExecuteQuery();

            foreach (Folder subFolder in folders)
            {
                if (subFolder.Name == mainFolder)
                {
                    if (subFolder.Folders.AreItemsAvailable)
                    {
                        foreach (Folder item in subFolder.Folders)
                        {
                            if (item.Name == folder)
                                return item;
                        }
                    }

                    Folder parent = AddSubFolder(context, subFolder, folder);
                    return parent;
                }
            }
            return null;
        }
        private static Folder AddSubFolder(ClientContext context, Folder ParentFolder, string folderName)
        {
            Folder resultFolder = ParentFolder.Folders.Add(folderName);
            context.ExecuteQuery();
            return resultFolder;
        }
    }
}