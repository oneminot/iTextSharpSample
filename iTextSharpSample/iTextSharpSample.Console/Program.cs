using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;

namespace iTextSharpSample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDocument = new iTextSharp.text.Document();
            iTextSharp.text.pdf.PdfWriter.GetInstance(myDocument, new FileStream("test.pdf", FileMode.CreateNew));
            myDocument.Open();
            myDocument.Add(new Paragraph("Hello, world!"));
            myDocument.Close();
        }
    }
}
