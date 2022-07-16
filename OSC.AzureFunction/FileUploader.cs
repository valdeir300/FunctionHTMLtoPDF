using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace OSC.AzureFunction
{
    public static class FileUploader
    {
        [FunctionName("FileUploader")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, ILogger log)
        {
            string responseMessage = string.Empty;
            try
            {
            
                var fileChunk = await req.ReadAsStringAsync();
                

                //log.LogInformation("Processing PDF Request");
                //string html = await req.ReadAsStringAsync();


            }
            catch (System.Exception error)
            {
                responseMessage = error.Message;
                return new NotFoundObjectResult(responseMessage);

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
        private static void ReadFile(string filePath)
        {
            const int MAX_BUFFER = 1048576; //1MB 
            byte[] buffer = new byte[MAX_BUFFER];
            int bytesRead;
            int noOfFiles = 0;
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                while ((bytesRead = bs.Read(buffer, 0, MAX_BUFFER)) != 0) //reading 1mb chunks at a time
                {
                    noOfFiles++;
                    //Let's create a small size file using the data. Or Pass this data for any further processing.

                    File.WriteAllBytes($"Test{noOfFiles}.txt", buffer);
                }
            }
        }

        public static void SplitFile(string inputFile, int chunkSize, string path)
        {
            const int BUFFER_SIZE = 20 * 1024;
            byte[] buffer = new byte[BUFFER_SIZE];

            using (Stream input = File.OpenRead(inputFile))
            {
                int index = 0;
                while (input.Position < input.Length)
                {
                    using (Stream output = File.Create(path + "\\" + index))
                    {
                        int remaining = chunkSize, bytesRead;
                        while (remaining > 0 && (bytesRead = input.Read(buffer, 0,
                                Math.Min(remaining, BUFFER_SIZE))) > 0)
                        {
                            output.Write(buffer, 0, bytesRead);
                            remaining -= bytesRead;
                        }
                    }
                    index++;
                    Thread.Sleep(500); // experimental; perhaps try it
                }
            }
        }
    }
}

