using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using Spire.Pdf;
using Spire.Pdf.Exporting.Text;
using System.IO;

namespace ExtractText
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfDocument document = new PdfDocument();
            document.LoadFromFile("C:\\Users\\atillam\\Desktop\\output.pdf");

            StringBuilder content = new StringBuilder();
            content.Append(document.Pages[0].ExtractText());
            content.Append(document.Pages[1].ExtractText());
            content.Append(document.Pages[2].ExtractText());
            content.Append(document.Pages[3].ExtractText());
            content.Append(document.Pages[4].ExtractText());
            content.Append(document.Pages[5].ExtractText());
            content.Append(document.Pages[6].ExtractText());
            content.Append(document.Pages[7].ExtractText());
            content.Append(document.Pages[8].ExtractText());


            String fileName = "TextFromPDF.txt";
            File.WriteAllText(fileName, content.ToString());
            System.Diagnostics.Process.Start("TextFromPDF.txt");

        }
    }
}