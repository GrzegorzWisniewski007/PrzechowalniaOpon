using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzechowalniaOpon.helpers
{
    public static class printHelper
    {
        public static void printPDFWithAcrobat(string folder,string fileName, string fileExtension)
        {
            string m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string Filepath = @m_exePath + "\\"+ folder+"\\" + fileName+"."+ fileExtension;

            using (PrintDialog Dialog = new PrintDialog())
            {
                Dialog.ShowDialog();

                ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    FileName = Filepath,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process printProcess = new Process();
                printProcess.StartInfo = printProcessInfo;
                printProcess.Start();

                printProcess.WaitForInputIdle();

                Thread.Sleep(3000);

                if (false == printProcess.CloseMainWindow())
                {
                    printProcess.Kill();
                }
            }
        }
    }
}
