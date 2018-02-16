using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;
using PrzechowalniaOpon.helpers;
using PrzechowalniaOpon.models;
using PrzechowalniaOpon.repositories;
using System.IO;
using PrzechowalniaOpon.entitydb;
using PrzechowalniaOpon.common;
using System.Reflection;
using System.Diagnostics;
using System.Threading;

namespace PrzechowalniaOpon
{
    public partial class Form1 : Form
    {
        // [snip] - As C# is purely object-oriented the following lines must be put into a class:
        // We use these three SQLite objects:
        public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
        public AddClient AddClientForm;
        public TireRepository db = new TireRepository();
        public ClientRepository dbClient = new ClientRepository();

        public Form1()
        {
            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=przechowalnia.db;Version=3;New=False;Compress=True;");
            InitializeComponent();
            loadClientsTable();
            loadTiresTable();
            addClientEditButton();
            addClientDeleteButton();
            addTireEditButton();
            addTireSpendButton();
            addTireDeleteButton();
            dGVClients.CellClick += dGVClients_CellClick;
            dGVTires.CellClick += dGVTires_CellClick;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dGVClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dGVClients.Columns["edit_column"].Index)
            {
                var model = dbClient.getById((int)dGVClients.Rows[dGVClients.CurrentRow.Index].Cells["id"].Value);
                AddClient AddClientForm = new AddClient(this, model);
                AddClientForm.Show();
            }

            if (e.ColumnIndex == dGVClients.Columns["delete_client"].Index)
            {
                //Do something with your button.
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Jesteś pewien, że chcesz usunąć?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(dGVClients.Rows[dGVClients.CurrentRow.Index].Cells["id"].Value.ToString());
                        dbClient.deleteClientById(id);
                        loadClientsTable();
                        //MessageBox.Show("Usunięto.");
                    }
                }
                catch (Exception ex)
                {
                    Logging.LogWrite(ex.Message);
                    MessageBox.Show("Nie można usunąć.");
                }
            }

        }

        private void dGVTires_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dGVTires.Columns["edit_column"].Index)
            {
                var model = db.getById((int)dGVTires.Rows[dGVTires.CurrentRow.Index].Cells["id"].Value);
                AddTire AddTireForm = new AddTire(this, model);
                AddTireForm.Show();
            }
            if (e.ColumnIndex == dGVTires.Columns["spend_column"].Index)
            {
                var model = db.getById((int)dGVTires.Rows[dGVTires.CurrentRow.Index].Cells["id"].Value);
                spendFromStock(model);
                loadTiresTable();
                MessageBox.Show("Wydano z magazynu.");
            }
            if (e.ColumnIndex == dGVTires.Columns["delete_column"].Index)
            {
                //Do something with your button.
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Jesteś pewien, że chcesz usunąć?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(dGVTires.Rows[dGVTires.CurrentRow.Index].Cells["id"].Value.ToString());
                        db.deleteTireById(id);
                        loadTiresTable();
                        //MessageBox.Show("Usunięto.");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }

                }
                catch (Exception ex)
                {
                    Logging.LogWrite(ex.Message);
                    MessageBox.Show("Nie można usunąć.");
                }
            }
        }

        public void loadClientsTable()
        {
            var res = dbClient.getClients();
            if (res != null)
            {
                var list = new BindingList<Clients>(res);
                dGVClients.DataSource = list;
            }
            dGVClients.Columns["full_name"].Visible = false;
        }

        public void loadTiresTable()
        {
            var res = db.getTires();

            var list = new BindingList<Tires>(res);
            dGVTires.DataSource = list;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm = new AddClient(this);
            AddClientForm.Show();
        }


        private void addTireEditButton()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "edit_column";
            button.Text = "Edytuj";
            button.HeaderText = "";
            button.UseColumnTextForButtonValue = true;

            int columnIndex = 8;
            if (dGVTires.Columns["edit_column"] == null)
            {
                dGVTires.Columns.Insert(columnIndex, button);
            }
        }

        private void addClientEditButton()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "edit_column";
            button.Text = "Edytuj";
            button.HeaderText = "";
            button.UseColumnTextForButtonValue = true;

            int columnIndex = 6;
            if (dGVClients.Columns["edit_column"] == null)
            {
                dGVClients.Columns.Insert(columnIndex, button);
            }

        }

        private void addClientDeleteButton()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "delete_client";
            button.Text = "Usuń";
            button.HeaderText = "";
            button.UseColumnTextForButtonValue = true;

            int columnIndex = 7;
            if (dGVClients.Columns["delete_client"] == null)
            {
                dGVClients.Columns.Insert(columnIndex, button);
            }

        }

        private void addTireSpendButton()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "spend_column";
            button.Text = "Wydaj z magazynu";
            button.HeaderText = "";
            button.UseColumnTextForButtonValue = true;

            int columnIndex = 8;
            if (dGVTires.Columns["spend_column"] == null)
            {
                dGVTires.Columns.Insert(columnIndex, button);
            }
        }

        private void addTireDeleteButton()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "delete_column";
            button.Text = "Usuń";
            button.HeaderText = "";
            button.UseColumnTextForButtonValue = true;

            int columnIndex = 10;
            if (dGVTires.Columns["delete_column"] == null)
            {
                dGVTires.Columns.Insert(columnIndex, button);
            }
        }

        private void bAddTire_Click(object sender, EventArgs e)
        {
            AddTire AddTireForm = new AddTire(this);
            AddTireForm.Show();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wykonajPlikSQLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Logging.LogWrite("Test close");
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "MSSQL files (*.sql)|*.sql";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                            //MessageBox.Show(sr.ReadToEnd());
                            executeSQL(sr.ReadToEnd());
                            sr.Close();
                            MessageBox.Show("Wykonano instrukcje zawarte w pliku SQL");
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logging.LogWrite(ex.Message);
                    MessageBox.Show("Nie udało się wykonać polecania SQL. " + ex.Message);
                }
            }
        }

        private bool executeSQL(string file)
        {
            initialize dbContext = new initialize("przechowalnia", "True");
            // open the connection:
            dbContext.sqlite_conn.Open();

            // create a new SQL command:
            dbContext.sqlite_cmd = dbContext.sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            dbContext.sqlite_cmd.CommandText = file;

            dbContext.sqlite_cmd.ExecuteNonQuery();

            // We are ready, now lets cleanup and close our connection:
            dbContext.sqlite_conn.Close();

            return true;
        }

        private void logiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logs LogForm = new Logs(this);
            LogForm.Show();
        }

        private void spendFromStock(Tires model)
        {
            try
            {
                DateTime now = DateTime.Now;
                model.date_release = now.ToString("yyyy-MM-dd HH:mm:ss");
                model.client = model.getClient(model.client_id);
                documentHelper documentH = new documentHelper();
                string html = documentH.spendPdf(model);
                var result = pdfHelper.PdfSharpConvert(html, "wydania", "wydnaie", "pdf");
                db.spendTire(model);
            }
            catch (Exception ex)
            {
                Logging.LogWrite(ex.Message);
                MessageBox.Show("Wystąpił nieoczekiwany wyjątek. \r\n" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test = db.getLast();
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            try
            {
                documentHelper documentH = new documentHelper();
                string html = documentH.clientList(dbClient.getClients());
                var result = pdfHelper.PdfSharpConvert(html, "listy", "lista klientów", "pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd.\r\n" + ex.Message);
            }
        }

        private void btnTireList_Click(object sender, EventArgs e)
        {
            try
            {
                documentHelper documentH = new documentHelper();
                string html = documentH.tireList(db.getTires());
                var result = pdfHelper.PdfSharpConvert(html, "listy", "lista opon", "pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd.\r\n" + ex.Message);
            }
        }
    }
}
