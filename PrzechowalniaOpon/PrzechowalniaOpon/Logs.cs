using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzechowalniaOpon
{
    public partial class Logs : Form
    {
        public Logs(Form1 form)
        {
            InitializeComponent();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            try
            {
                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                using (FileStream fs = File.Open(path + "\\" + "log.txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);

                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        tBLogs.Text += temp.GetString(b);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się odczytać pliku.\r\n" + ex.Message);
            }
        }
    }
}
