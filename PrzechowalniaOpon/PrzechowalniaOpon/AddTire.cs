using PrzechowalniaOpon.helpers;
using PrzechowalniaOpon.models;
using PrzechowalniaOpon.repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzechowalniaOpon
{
    public partial class AddTire : Form
    {
        public Form1 mainForm;
        public bool isNew = true;
        public Tires tiresModel;
        public AddTire(Form1 form, Tires model = null)
        {
            InitializeComponent();
            loadComboSeasons();
            loadClients();
            loadComboRims();
            if (model != null)
            {
                isNew = false;
                fillForm(model);
                tiresModel = model;
            }
            mainForm = form;
        }

        private void AddTire_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTire_Click(object sender, EventArgs e)
        {
            TireRepository db = new TireRepository();
            try
            {
                if (isNew)
                {
                    var result = createTire();
                    if (result != null)
                    {
                        this.Close();
                    }
                }
                else
                {
                    var result = saveTire();
                    if (result != null)
                    {
                        this.Close();
                    }
                }
                mainForm.loadTiresTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany wyjątek.\r\n" + ex.Message);
            }
        }

        private Tires createTire()
        {
            var model = loadTireModel();

            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(model, new ValidationContext(model, null, null), results, true))
            {
                MessageBox.Show(model.validationMessage(results));
                return null;
            }
            else
            {
                TireRepository db = new TireRepository();
                db.setNewTire(model);
                MessageBox.Show("Dodano nowy zestaw opon: " + model.manufacturer + " " + model.size);
                return model;
            }
        }

        private Tires saveTire()
        {
            var model = loadTireModel();

            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(model, new ValidationContext(model, null, null), results, true))
            {
                MessageBox.Show(model.validationMessage(results));
                return null;
            }
            else
            {
                TireRepository db = new TireRepository();
                db.updateTire(model);
                MessageBox.Show("Zmiany zostały zapisane.");
                return model;
            }
        }

        private void loadClients()
        {
            cBClients.DataSource = getClients();
            cBClients.DisplayMember = "full_name";
            cBClients.ValueMember = "id";
        }

        private List<Clients> getClients()
        {
            ClientRepository db = new ClientRepository();
            return db.getClients();
        }

        private void loadComboRims()
        {
            cBRims.DataSource = getRims();
            cBRims.DisplayMember = "name";
            cBRims.ValueMember = "id";
        }

        private List<RimsDict> getRims()
        {
            RimsDictRepository db = new RimsDictRepository();
            return db.getRims();
        }

        private void loadComboSeasons()
        {
            cBSeason.DataSource = getSeasons();
            cBSeason.DisplayMember = "name";
            cBSeason.ValueMember = "id";
        }

        private List<SeasonDict> getSeasons()
        {
            SeasonDictRepository db = new SeasonDictRepository();
            return db.getSeasons();
        }

        /// <summary>
        /// Ładowanie modelu w celu edycji
        /// </summary>
        /// <returns></returns>
        private Tires loadTireModel()
        {
            Tires model = new Tires();
            model.manufacturer = tBManufacturer.Text;
            model.quantity = Convert.ToInt32(nUDQuantity.Value);
            model.rims_id = (int)cBRims.SelectedValue;
            model.size = tBsize.Text;
            model.season_id = (int)cBSeason.SelectedValue;
            model.comments = tBComment.Text;
            model.client_id = (cBClients.SelectedValue != null ? (int)cBClients.SelectedValue : 0);
            model.treads = getTreadsFromForm();
            if (tiresModel != null)
            {
                model.id = tiresModel.id;
            }

            return model;
        }

        protected List<Treads> getTreadsFromForm()
        {
            List<Treads> list = new List<Treads>();
            //pobieram wszystkie kontrolki z formularza
            Control.ControlCollection controls = AddTire.ActiveForm.Controls;

            foreach (Control c in controls)
            {
                //jeżeli kontrolka ma tag
                if (c.Tag != null && c.Visible == true)
                {
                    var type = c.GetType();
                    string tag = (string)c.Tag;
                    int tire = Convert.ToInt32(tag.Substring(4, 1));
                    //jeżeli kontrolka to numericupdown 
                    if (type.FullName == "System.Windows.Forms.NumericUpDown")
                    {
                        NumericUpDown nup = c as NumericUpDown;
                        list.Add(new Treads
                        {
                            tread = nup.Value.ToString()
                        });
                        c.Visible = true;
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Wypełnienie formularza dla edycji
        /// </summary>
        /// <param name="model"></param>
        private void fillForm(Tires model)
        {
            tBManufacturer.Text = model.manufacturer;
            nUDQuantity.Value = model.quantity;
            cBRims.SelectedValue = model.rims_id;
            tBsize.Text = model.size;
            cBSeason.SelectedValue = model.season_id;
            tBComment.Text = model.comments;
            cBClients.SelectedValue = model.client_id;
            fillTreadForms(model);
            btnAddTire.Text = "Zapisz";
            this.Text = "Edycja";
        }

        protected bool fillTreadForms(Tires model)
        {
            nUDQuantity.Value = model.treads.Count;
            int i = 1;
            foreach (Treads tread in model.treads)
            {
                var numeric = FindByName("nUDtire" + i);
                if(numeric.GetType().ToString() == "System.Windows.Forms.NumericUpDown")
                {
                    NumericUpDown nup = numeric as NumericUpDown;
                    nup.Visible = true;
                    nup.Value = Convert.ToDecimal(tread.tread);
                }
                var label = FindByName("lTire" + i);
                if (label.GetType().ToString() == "System.Windows.Forms.Label")
                {
                    Label l = label as Label;
                    l.Visible = true;                    
                }

                i++;
            }
            return true;
        }

        /// <summary>
        /// Zmiana ilości opon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nUDQuantity_ValueChanged(object sender, EventArgs e)
        {
            int quantity = (int)nUDQuantity.Value;

            //pobieram wszystkie kontrolki z formularza
            Control.ControlCollection controls = AddTire.ActiveForm.Controls;


            foreach (Control c in controls)
            {
                //jeżeli kontrolka ma tag
                if (c.Tag != null)
                {
                    //to ją ukrywam, robię ta z każdą
                    c.Visible = false;
                    //przygotowuję tag do przetworzenia
                    string tag = (string)c.Tag;
                    int tire = Convert.ToInt32(tag.Substring(4, 1));
                    //jeżeli numericupdown zawiera się w ilości opon to go pokazuję
                    if (tire <= quantity)
                    {
                        c.Visible = true;
                    }
                }
            }
        }

        protected Control FindByName(string Name)
        {
            //pobieram wszystkie kontrolki z formularza
            //AddTire.ControlCollection controls = new AddTire.ControlCollection(this);
            Control[] controls = this.Controls.Find(Name, false);
            //Control.ControlCollection controls = this.Controls;

            foreach (Control c in controls)
            {
                //jeżeli kontrolka ma tag
                if (c.Name == Name)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
