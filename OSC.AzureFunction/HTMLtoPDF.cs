using DinkToPdf;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using IPdfConverter = DinkToPdf.Contracts.IConverter;

namespace OSC.AzureFunction
{
    public static class HTMLtoPDF
    {
        private static readonly IPdfConverter _pdfConverter = new SynchronizedConverter(new PdfTools());

        [FunctionName("HTMLtoPDF")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req, ILogger log)
        {
            try
            {
                log.LogInformation("Processing PDF Request");
                string html = await req.ReadAsStringAsync();

                var pdf = BuildPdf(html);

                log.LogInformation($"PDF Generated. Length={pdf.Length}");

                var res = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent(pdf)
                };

                res.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                res.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("inline");

                return res;
            }
            catch (System.Exception error)
            {
                throw error;
            }
        }

        private static byte[] BuildPdf(string html)
        {
            const double margin = 5;
            byte[] PDFFile = _pdfConverter.Convert(new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings(margin, margin, margin, margin),
                },
                Objects =
                {
                    new ObjectSettings
                    {
                        WebSettings = new WebSettings
                        {
                            PrintMediaType = true,
                            EnableIntelligentShrinking = true
                        },
                        HtmlContent = html
                    }
                }
            });
            return PDFFile;
        }
    }
}