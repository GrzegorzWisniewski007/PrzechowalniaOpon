using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzechowalniaOpon.helpers
{
    public static class pdfHelper
    {
        public static Byte[] PdfSharpConvert(String html,string folder, string fileName, string fileExtension)
        {
            string filename = "";
            string m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Byte[] res = null;
            using (MemoryStream ms = new MemoryStream())
            {
                var pdf = TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = fileName;
                dialog.DefaultExt = "."+ fileExtension;
                //dialog.Filter = "PDF documents (.pdf)|*.pdf";
                // Show save file dialog box
                

                // Process save file dialog box results 
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Save document 
                    filename = dialog.FileName;
                }
                pdf.Save(filename);
                res = ms.ToArray();
            }
            return res;
        }
    }
}
