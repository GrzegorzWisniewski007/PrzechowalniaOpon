namespace PrzechowalniaOpon
{
    partial class AddTire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTire));
            this.tBManufacturer = new System.Windows.Forms.TextBox();
            this.nUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.cBClients = new System.Windows.Forms.ComboBox();
            this.btnAddTire = new System.Windows.Forms.Button();
            this.lManufacturer = new System.Windows.Forms.Label();
            this.tBsize = new System.Windows.Forms.TextBox();
            this.lSize = new System.Windows.Forms.Label();
            this.cBSeason = new System.Windows.Forms.ComboBox();
            this.lSeason = new System.Windows.Forms.Label();
            this.lQuantity = new System.Windows.Forms.Label();
            this.cBRims = new System.Windows.Forms.ComboBox();
            this.lRims = new System.Windows.Forms.Label();
            this.lClient = new System.Windows.Forms.Label();
            this.tBComment = new System.Windows.Forms.TextBox();
            this.lCommet = new System.Windows.Forms.Label();
            this.nUDtire1 = new System.Windows.Forms.NumericUpDown();
            this.nUDtire2 = new System.Windows.Forms.NumericUpDown();
            this.nUDtire3 = new System.Windows.Forms.NumericUpDown();
            this.nUDtire4 = new System.Windows.Forms.NumericUpDown();
            this.lTire1 = new System.Windows.Forms.Label();
            this.lTire2 = new System.Windows.Forms.Label();
            this.lTire3 = new System.Windows.Forms.Label();
            this.lTire4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtire1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtire3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtire4)).BeginInit();
            this.SuspendLayout();
            // 
            // tBManufacturer
            // 
            this.tBManufacturer.Location = new System.Drawing.Point(12, 69);
            this.tBManufacturer.Name = "tBManufacturer";
            this.tBManufacturer.Size = new System.Drawing.Size(149, 20);
            this.tBManufacturer.TabIndex = 0;
            // 
            // nUDQuantity
            // 
            this.nUDQuantity.Location = new System.Drawing.Point(194, 25);
            this.nUDQuantity.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUDQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDQuantity.Name = "nUDQuantity";
            this.nUDQuantity.Size = new System.Drawing.Size(55, 20);
            this.nUDQuantity.TabIndex = 1;
            this.nUDQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDQuantity.ValueChanged += new System.EventHandler(this.nUDQuantity_ValueChanged);
            // 
            // cBClients
            // 
            this.cBClients.FormattingEnabled = true;
            this.cBClients.Location = new System.Drawing.Point(12, 24);
            this.cBClients.Name = "cBClients";
            this.cBClients.Size = new System.Drawing.Size(149, 21);
            this.cBClients.TabIndex = 2;
            // 
            // btnAddTire
            // 
            this.btnAddTire.Location = new System.Drawing.Point(297, 401);
            this.btnAddTire.Name = "btnAddTire";
            this.btnAddTire.Size = new System.Drawing.Size(122, 23);
            this.btnAddTire.TabIndex = 3;
            this.btnAddTire.Text = "Przyjmij na magazyn";
            this.btnAddTire.UseVisualStyleBackColor = true;
            this.btnAddTire.Click += new System.EventHandler(this.btnAddTire_Click);
            // 
            // lManufacturer
            // 
            this.lManufacturer.AutoSize = true;
            this.lManufacturer.Location = new System.Drawing.Point(12, 53);
            this.lManufacturer.Name = "lManufacturer";
            this.lManufacturer.Size = new System.Drawing.Size(56, 13);
            this.lManufacturer.TabIndex = 4;
            this.lManufacturer.Text = "Producent";
            // 
            // tBsize
            // 
            this.tBsize.Location = new System.Drawing.Point(12, 165);
            this.tBsize.Name = "tBsize";
            this.tBsize.Size = new System.Drawing.Size(149, 20);
            this.tBsize.TabIndex = 5;
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Location = new System.Drawing.Point(12, 149);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(45, 13);
            this.lSize.TabIndex = 6;
            this.lSize.Text = "Rozmiar";
            // 
            // cBSeason
            // 
            this.cBSeason.FormattingEnabled = true;
            this.cBSeason.Location = new System.Drawing.Point(12, 212);
            this.cBSeason.Name = "cBSeason";
            this.cBSeason.Size = new System.Drawing.Size(149, 21);
            this.cBSeason.TabIndex = 7;
            // 
            // lSeason
            // 
            this.lSeason.AutoSize = true;
            this.lSeason.Location = new System.Drawing.Point(12, 196);
            this.lSeason.Name = "lSeason";
            this.lSeason.Size = new System.Drawing.Size(37, 13);
            this.lSeason.TabIndex = 8;
            this.lSeason.Text = "Sezon";
            // 
            // lQuantity
            // 
            this.lQuantity.AutoSize = true;
            this.lQuantity.Location = new System.Drawing.Point(191, 9);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(29, 13);
            this.lQuantity.TabIndex = 9;
            this.lQuantity.Text = "Ilość";
            // 
            // cBRims
            // 
            this.cBRims.FormattingEnabled = true;
            this.cBRims.Location = new System.Drawing.Point(12, 114);
            this.cBRims.Name = "cBRims";
            this.cBRims.Size = new System.Drawing.Size(149, 21);
            this.cBRims.TabIndex = 10;
            // 
            // lRims
            // 
            this.lRims.AutoSize = true;
            this.lRims.Location = new System.Drawing.Point(12, 98);
            this.lRims.Name = "lRims";
            this.lRims.Size = new System.Drawing.Size(29, 13);
            this.lRims.TabIndex = 11;
            this.lRims.Text = "Felgi";
            // 
            // lClient
            // 
            this.lClient.AutoSize = true;
            this.lClient.Location = new System.Drawing.Point(12, 8);
            this.lClient.Name = "lClient";
            this.lClient.Size = new System.Drawing.Size(33, 13);
            this.lClient.TabIndex = 12;
            this.lClient.Text = "Klient";
            // 
            // tBComment
            // 
            this.tBComment.Location = new System.Drawing.Point(12, 264);
            this.tBComment.Multiline = true;
            this.tBComment.Name = "tBComment";
            this.tBComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBComment.Size = new System.Drawing.Size(410, 129);
            this.tBComment.TabIndex = 13;
            // 
            // lCommet
            // 
            this.lCommet.AutoSize = true;
            this.lCommet.Location = new System.Drawing.Point(12, 248);
            this.lCommet.Name = "lCommet";
            this.lCommet.Size = new System.Drawing.Size(37, 13);
            this.lCommet.TabIndex = 14;
            this.lCommet.Text = "Uwagi";
            // 
            // nUDtire1
            // 
            this.nUDtire1.DecimalPlaces = 2;
            this.nUDtire1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUDtire1.Location = new System.Drawing.Point(194, 70);
            this.nUDtire1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nUDtire1.Name = "nUDtire1";
            this.nUDtire1.Size = new System.Drawing.Size(55, 20);
            this.nUDtire1.TabIndex = 15;
            this.nUDtire1.Tag = "Tire1";
            this.nUDtire1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nUDtire2
            // 
            this.nUDtire2.DecimalPlaces = 2;
            this.nUDtire2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUDtire2.Location = new System.Drawing.Point(194, 121);
            this.nUDtire2.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nUDtire2.Name = "nUDtire2";
            this.nUDtire2.Size = new System.Drawing.Size(55, 20);
            this.nUDtire2.TabIndex = 16;
            this.nUDtire2.Tag = "Tire2";
            this.nUDtire2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDtire2.Visible = false;
            // 
            // nUDtire3
            // 
            this.nUDtire3.DecimalPlaces = 2;
            this.nUDtire3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUDtire3.Location = new System.Drawing.Point(194, 168);
            this.nUDtire3.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nUDtire3.Name = "nUDtire3";
            this.nUDtire3.Size = new System.Drawing.Size(55, 20);
            this.nUDtire3.TabIndex = 17;
            this.nUDtire3.Tag = "Tire3";
            this.nUDtire3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDtire3.Visible = false;
            // 
            // nUDtire4
            // 
            this.nUDtire4.DecimalPlaces = 2;
            this.nUDtire4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUDtire4.Location = new System.Drawing.Point(194, 214);
            this.nUDtire4.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nUDtire4.Name = "nUDtire4";
            this.nUDtire4.Size = new System.Drawing.Size(55, 20);
            this.nUDtire4.TabIndex = 18;
            this.nUDtire4.Tag = "Tire4";
            this.nUDtire4.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDtire4.Visible = false;
            // 
            // lTire1
            // 
            this.lTire1.AutoSize = true;
            this.lTire1.Location = new System.Drawing.Point(191, 54);
            this.lTire1.Name = "lTire1";
            this.lTire1.Size = new System.Drawing.Size(157, 13);
            this.lTire1.TabIndex = 19;
            this.lTire1.Tag = "Tire1";
            this.lTire1.Text = "Wysokość bieżnika dla opony 1";
            // 
            // lTire2
            // 
            this.lTire2.AutoSize = true;
            this.lTire2.Location = new System.Drawing.Point(191, 105);
            this.lTire2.Name = "lTire2";
            this.lTire2.Size = new System.Drawing.Size(157, 13);
            this.lTire2.TabIndex = 20;
            this.lTire2.Tag = "Tire2";
            this.lTire2.Text = "Wysokość bieżnika dla opony 2";
            this.lTire2.Visible = false;
            // 
            // lTire3
            // 
            this.lTire3.AutoSize = true;
            this.lTire3.Location = new System.Drawing.Point(191, 152);
            this.lTire3.Name = "lTire3";
            this.lTire3.Size = new System.Drawing.Size(157, 13);
            this.lTire3.TabIndex = 21;
            this.lTire3.Tag = "Tire3";
            this.lTire3.Text = "Wysokość bieżnika dla opony 3";
            this.lTire3.Visible = false;
            // 
            // lTire4
            // 
            this.lTire4.AutoSize = true;
            this.lTire4.Location = new System.Drawing.Point(191, 198);
            this.lTire4.Name = "lTire4";
            this.lTire4.Size = new System.Drawing.Size(157, 13);
            this.lTire4.TabIndex = 22;
            this.lTire4.Tag = "Tire4";
            this.lTire4.Text = "Wysokość bieżnika dla opony 4";
            this.lTire4.Visible = false;
            // 
            // AddTire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 428);
            this.Controls.Add(this.lTire4);
            this.Controls.Add(this.lTire3);
            this.Controls.Add(this.lTire2);
            this.Controls.Add(this.lTire1);
            this.Controls.Add(this.nUDtire4);
            this.Controls.Add(this.nUDtire3);
            this.Controls.Add(this.nUDtire2);
            this.Controls.Add(this.nUDtire1);
            this.Controls.Add(this.lCommet);
            this.Controls.Add(this.tBComment);
            this.Controls.Add(this.lClient);
            this.Controls.Add(this.lRims);
            this.Controls.Add(this.cBRims);
            this.Controls.Add(this.lQuantity);
            this.Controls.Add(this.lSeason);
            this.Controls.Add(this.cBSeason);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.tBsize);
            this.Controls.Add(this.lManufacturer);
            this.Controls.Add(this.btnAddTire);
            this.Controls.Add(this.cBClients);
            this.Controls.Add(this.nUDQuantity);
            this.Controls.Add(this.tBManufacturer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTire";
            this.Text = "Dodaj zestaw opon";
            this.Load += new System.EventHandler(this.AddTire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtire1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtire3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDtire4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBManufacturer;
        private System.Windows.Forms.NumericUpDown nUDQuantity;
        private System.Windows.Forms.ComboBox cBClients;
        private System.Windows.Forms.Button btnAddTire;
        private System.Windows.Forms.Label lManufacturer;
        private System.Windows.Forms.TextBox tBsize;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.ComboBox cBSeason;
        private System.Windows.Forms.Label lSeason;
        private System.Windows.Forms.Label lQuantity;
        private System.Windows.Forms.ComboBox cBRims;
        private System.Windows.Forms.Label lRims;
        private System.Windows.Forms.Label lClient;
        private System.Windows.Forms.TextBox tBComment;
        private System.Windows.Forms.Label lCommet;
        private System.Windows.Forms.NumericUpDown nUDtire1;
        private System.Windows.Forms.NumericUpDown nUDtire2;
        private System.Windows.Forms.NumericUpDown nUDtire3;
        private System.Windows.Forms.NumericUpDown nUDtire4;
        private System.Windows.Forms.Label lTire1;
        private System.Windows.Forms.Label lTire2;
        private System.Windows.Forms.Label lTire3;
        private System.Windows.Forms.Label lTire4;
    }
}