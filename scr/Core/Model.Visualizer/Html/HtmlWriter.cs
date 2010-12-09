using System;
using System.Net.Mail;
using RazorEngine;
using RazorEngine.Templating;

namespace BDDish
{
    public class HtmlWriter
    {
        public void Write(Feature feature)
        {
            //Razor.
        }

        public void WriterHeader()
        {
            var htmlHelloWorldMail = new MailMessage("alex@alexonasp.net", "alex@alexonasp.net") {IsBodyHtml = true};

            Razor.SetTemplateBaseType(typeof(HtmlTemplateBase<>));

            string htmlTemplate =
                @"<html>   
                    <head>   
                        <style type=\""text/css\"">   
                            body { font-family: Arial; }   
                        </style>   
                    </head>   
                    <body>   
                        <h1>Hello @Model.Name</h1>   
                        <p>Welcome to Razor Templating...</p>   
                    </body>   
                    </html>";

            var model = new { Name = "name" };

            string htmlBody = Razor.Parse(htmlTemplate, model);
            htmlHelloWorldMail.Body = htmlBody;               

        }
    }
}