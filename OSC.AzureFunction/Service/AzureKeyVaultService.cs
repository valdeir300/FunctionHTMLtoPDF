using System;

namespace OSC.AzureFunction.Service
{
    public class AzureKeyVaultService
    {
        public static string GetSecret(string secret) {
            return Environment.GetEnvironmentVariable(secret);
        }
    }
}
