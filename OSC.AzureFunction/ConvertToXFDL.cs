using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OSC.AzureFunction.Data;
using OSC.AzureFunction.JsonModel;
using OSC.AzureFunction.Model;
using OSC.AzureFunction.Service;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;

namespace OSC.AzureFunction
{
    public static class ConvertToXFDL
    {
        [FunctionName("ConvertToXFDL")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, ILogger log)
        {
            string responseMessage = string.Empty;
            try
            {
                log.LogInformation("Processing the Creation of XFDL File");
                string jsonObjectSerialized = await req.ReadAsStringAsync();

                string D365Table = req.Headers["D365Table"];
                string eForm = req.Headers["eForm"];
                string SubmissionID = req.Headers["SubmissionID"];
                string D365GUID = req.Headers["D365GUID"];
                string Date = req.Headers["Date"];
                string input = req.Headers["input"];

                switch (eForm)
                {
                    case "Whistleblower":
                        Root jsonObject = JsonConvert.DeserializeObject<Root>(jsonObjectSerialized);
                        XmlDocument xmlDocument = WhistleblowerService.Whistleblower(jsonObject);
                        // LOCAL DIRETORY TO TEST
                        // XFDLService.SaveXFDL(xmlDocument, $"{eForm}_{D365GUID}");
                        SharePointProcess(xmlDocument, $"{eForm}_{D365GUID}", "Files");
                        break;
                    default:
                        break;
                }
                responseMessage = $"Files created in SharePoint";
                SharePointProcess("Files", "Checksum Files");
            }
            catch (System.Exception error)
            {
                responseMessage = $"Error: {error.Message}";
                return new NotFoundObjectResult(responseMessage);
            }
            return new OkObjectResult(responseMessage);
        }

        private static void SharePointProcess(string folderName, string checksumFolderName)
        {
            SharePointParameters param = new SharePointParameters();
            List<SharePointModel> SharePointFiles = SharePointData.GetBynaryFilesFroSharePoint(param.siteUrl, param.appID, param.appSecret, folderName);
            SharePointData.CreateSHA512FileInSharePoint(param.siteUrl, param.appID, param.appSecret, folderName, checksumFolderName, SharePointFiles);
        }
        private static void SharePointProcess(XmlDocument xmlDocument, string fileName, string folderName)
        {
            SharePointParameters param = new SharePointParameters();
            SharePointData.CreateXFDLFileInSharePoint(param.siteUrl, param.appID, param.appSecret, folderName, xmlDocument, fileName);
        }
    }
}