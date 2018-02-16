namespace PrzechowalniaOpon
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbDataReader = new System.Windows.Forms.TextBox();
            this.dGVClients = new System.Windows.Forms.DataGridView();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.cTForm1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bAddTire = new System.Windows.Forms.Button();
            this.dGVTires = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.narzędziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykonajPlikSQLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClientList = new System.Windows.Forms.Button();
            this.btnTireList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClients)).BeginInit();
            this.cTForm1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTires)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDataReader
            // 
            this.tbDataReader.Location = new System.Drawing.Point(12, 41);
            this.tbDataReader.Multiline = true;
            this.tbDataReader.Name = "tbDataReader";
            this.tbDataReader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDataReader.Size = new System.Drawing.Size(361, 59);
            this.tbDataReader.TabIndex = 1;
            // 
            // dGVClients
            // 
            this.dGVClients.AllowUserToAddRows = false;
            this.dGVClients.AllowUserToDeleteRows = false;
            this.dGVClients.AllowUserToOrderColumns = true;
            this.dGVClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClients.Location = new System.Drawing.Point(-4, 42);
            this.dGVClients.Name = "dGVClients";
            this.dGVClients.Size = new System.Drawing.Size(753, 428);
            this.dGVClients.TabIndex = 2;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(6, 6);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(90, 23);
            this.btnAddClient.TabIndex = 3;
            this.btnAddClient.Text = "Dodaj klienta";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // cTForm1
            // 
            this.cTForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cTForm1.Controls.Add(this.tabPage1);
            this.cTForm1.Controls.Add(this.tabPage2);
            this.cTForm1.Location = new System.Drawing.Point(12, 121);
            this.cTForm1.Name = "cTForm1";
            this.cTForm1.SelectedIndex = 0;
            this.cTForm1.Size = new System.Drawing.Size(760, 492);
            this.cTForm1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClientList);
            this.tabPage1.Controls.Add(this.dGVClients);
            this.tabPage1.Controls.Add(this.btnAddClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Klienci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTireList);
            this.tabPage2.Controls.Add(this.bAddTire);
            this.tabPage2.Controls.Add(this.dGVTires);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Opony";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bAddTire
            // 
            this.bAddTire.Location = new System.Drawing.Point(6, 6);
            this.bAddTire.Name = "bAddTire";
            this.bAddTire.Size = new System.Drawing.Size(113, 23);
            this.bAddTire.TabIndex = 4;
            this.bAddTire.Text = "Dodaj zestaw opon";
            this.bAddTire.UseVisualStyleBackColor = true;
            this.bAddTire.Click += new System.EventHandler(this.bAddTire_Click);
            // 
            // dGVTires
            // 
            this.dGVTires.AllowUserToAddRows = false;
            this.dGVTires.AllowUserToDeleteRows = false;
            this.dGVTires.AllowUserToOrderColumns = true;
            this.dGVTires.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVTires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVTires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTires.Location = new System.Drawing.Point(0, 42);
            this.dGVTires.Name = "dGVTires";
            this.dGVTires.Size = new System.Drawing.Size(753, 426);
            this.dGVTires.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawieniaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem1
            // 
            this.ustawieniaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narzędziaToolStripMenuItem});
            this.ustawieniaToolStripMenuItem1.Name = "ustawieniaToolStripMenuItem1";
            this.ustawieniaToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem1.Text = "Ustawienia";
            // 
            // narzędziaToolStripMenuItem
            // 
            this.narzędziaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wykonajPlikSQLToolStripMenuItem1,
            this.logiToolStripMenuItem});
            this.narzędziaToolStripMenuItem.Name = "narzędziaToolStripMenuItem";
            this.narzędziaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.narzędziaToolStripMenuItem.Text = "Narzędzia";
            // 
            // wykonajPlikSQLToolStripMenuItem1
            // 
            this.wykonajPlikSQLToolStripMenuItem1.Name = "wykonajPlikSQLToolStripMenuItem1";
            this.wykonajPlikSQLToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.wykonajPlikSQLToolStripMenuItem1.Text = "Wykonaj plik SQL";
            this.wykonajPlikSQLToolStripMenuItem1.Click += new System.EventHandler(this.wykonajPlikSQLToolStripMenuItem1_Click);
            // 
            // logiToolStripMenuItem
            // 
            this.logiToolStripMenuItem.Name = "logiToolStripMenuItem";
            this.logiToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.logiToolStripMenuItem.Text = "Logi";
            this.logiToolStripMenuItem.Click += new System.EventHandler(this.logiToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClientList
            // 
            this.btnClientList.Location = new System.Drawing.Point(102, 6);
            this.btnClientList.Name = "btnClientList";
            this.btnClientList.Size = new System.Drawing.Size(128, 23);
            this.btnClientList.TabIndex = 4;
            this.btnClientList.Text = "Zapisz listę jako pdf";
            this.btnClientList.UseVisualStyleBackColor = true;
            this.btnClientList.Click += new System.EventHandler(this.btnClientList_Click);
            // 
            // btnTireList
            // 
            this.btnTireList.Location = new System.Drawing.Point(125, 6);
            this.btnTireList.Name = "btnTireList";
            this.btnTireList.Size = new System.Drawing.Size(128, 23);
            this.btnTireList.TabIndex = 5;
            this.btnTireList.Text = "Zapisz listę jako pdf";
            this.btnTireList.UseVisualStyleBackColor = true;
            this.btnTireList.Click += new System.EventHandler(this.btnTireList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cTForm1);
            this.Controls.Add(this.tbDataReader);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Warsztat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVClients)).EndInit();
            this.cTForm1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTires)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDataReader;
        private System.Windows.Forms.DataGridView dGVClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TabControl cTForm1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dGVTires;
        private System.Windows.Forms.Button bAddTire;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem narzędziaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykonajPlikSQLToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem logiToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClientList;
        private System.Windows.Forms.Button btnTireList;
    }
}

