using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using OSC.AzureFunction.Data;
using OSC.AzureFunction.Model;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace OSC.AzureFunction
{
    public static class ChecksumApp
    {
        [FunctionName("ChecksumApp")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, ILogger log)
        {
            string responseMessage = string.Empty;
            try
            {
                string Folder = req.Headers["Folder"];
                string ChecksumFilder = req.Headers["ChecksumFilder"];

                if (string.IsNullOrEmpty(ChecksumFilder))
                    ChecksumFilder = "Checksum Files";

                if (string.IsNullOrEmpty(Folder))
                    responseMessage = $"Folder URL is Empty";

                if (!string.IsNullOrEmpty(responseMessage))
                {
                    return new OkObjectResult(responseMessage);
                }
                else
                {
                    SharePointParameters param = new SharePointParameters();
                    SharePointProcess(Folder, ChecksumFilder);
                    responseMessage = $"Checksum files Created on SharePoint";
                }
            }
            catch (System.Exception error)
            {
                return new BadRequestObjectResult(error);
            }

            return new OkObjectResult(responseMessage);
        }

        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
        private static void SharePointProcess(string folderName, string checksumFolderName)
        {
            SharePointParameters param = new SharePointParameters();
            List<SharePointModel> SharePointFiles = SharePointData.GetBynaryFilesFroSharePoint(param.siteUrl, param.appID, param.appSecret, folderName);
            SharePointData.CreateSHA512FileInSharePoint(param.siteUrl, param.appID, param.appSecret, folderName, checksumFolderName, SharePointFiles);
        }
    }
}
