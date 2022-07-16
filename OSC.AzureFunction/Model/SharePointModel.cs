using OSC.AzureFunction.Service;

namespace OSC.AzureFunction.Model
{
    public class SharePointModel
    {
        public Microsoft.SharePoint.Client.File File { get; }
        public byte[] binaryFileValue { get; }

        public SharePointModel(Microsoft.SharePoint.Client.File fileName, byte[] binaryFileValue)
        {
            this.File = fileName;
            this.binaryFileValue = binaryFileValue;
        }
    }
    public class SharePointParameters
    {
        public string siteUrl = "https://crmdynamics1.sharepoint.com/sites/POC";
        public string appID = "7acc9595-87fa-42ae-b62d-36864ceffbd4";
        public string appSecret = "2bnkqLHEB1qgyG6wstY3P31yaRFZF3ssfplaWZ9kUgE=";

        //public string siteUrl = AzureKeyVaultService.GetSecret("secret-sharepoint-url");
        //public string appID = AzureKeyVaultService.GetSecret("secret-sharepoint-appid");
        //public string appSecret = AzureKeyVaultService.GetSecret("secret-sharepoint-appsecret");
    }
    
}
