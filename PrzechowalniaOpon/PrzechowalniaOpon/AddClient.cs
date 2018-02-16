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
using System.ComponentModel.DataAnnotations;

namespace PrzechowalniaOpon
{
    public partial class AddClient : Form
    {

        // [snip] - As C# is purely object-oriented the following lines must be put into a class:
        // We use these three SQLite objects:
        public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
        public Form1 mainForm;

        public bool isNew = true;
        public Clients clientModel;

        public AddClient(Form1 form, Clients model = null)
        {
            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=przechowalnia.db;Version=3;New=False;Compress=True;");
            InitializeComponent();
            if (model != null)
            {
                isNew = false;
                fillForm(model);
                clientModel = model;
            }
            mainForm = form;
        }

        private void btnAddClientToDB_Click(object sender, EventArgs e)
        {
            ClientRepository db = new ClientRepository();
            try
            {
                if (isNew)
                {
                    var result = createClient();
                    if (result != null)
                    {
                        this.Close();
                    }
                }
                else
                {
                    var result = saveClient();
                    if (result != null)
                    {
                        this.Close();
                    }
                }                
                mainForm.loadClientsTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany wyjątek.\r\n" + ex.Message);
            }
        }        

        private Clients createClient()
        {
            Clients client = new Clients();
            client.first_name = tbFirstName.Text;
            client.last_name = tbLastName.Text;
            client.email = tbEmail.Text;
            client.phone = tbPhone.Text;


            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(client, new ValidationContext(client, null, null), results, true))
            {
                MessageBox.Show(client.validationMessage(results));
                return null;
            }
            else
            {
                ClientRepository db = new ClientRepository();
                var cl = db.getByEmail(client.email);
                if (cl.id != 0 && cl.email!="")
                {
                    MessageBox.Show("Klient o podanym adresie email już istnieje.");
                    return null;
                }
                db.setNewClient(client);
                MessageBox.Show("Dodano nowego klienta: " + client.first_name + " " + client.last_name);
                return client;
            }
        }

        private Clients saveClient()
        {
            var model = loadClientModel();

            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(model, new ValidationContext(model, null, null), results, true))
            {
                MessageBox.Show(model.validationMessage(results));
                return null;
            }
            else
            {
                ClientRepository db = new ClientRepository();
                db.updateClient(model);
                MessageBox.Show("Zmiany zostały zapisane.");
                return model;
            }
        }

        private Clients loadClientModel()
        {
            Clients model = new Clients();
            model.first_name = tbFirstName.Text;
            model.last_name = tbLastName.Text;
            model.email = tbEmail.Text;
            model.phone = tbPhone.Text;            
            if (clientModel != null)
            {
                model.id = clientModel.id;
            }

            return model;
        }

        private void fillForm(Clients model)
        {
            tbFirstName.Text = model.first_name;
            tbLastName.Text = model.last_name;
            tbEmail.Text = model.email;
            tbPhone.Text = model.phone;          
           
            btnAddClientToDB.Text = "Zapisz";
            this.Text = "Edycja klienta";
        }


    }
}
