namespace PrzechowalniaOpon
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lFirstName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lLastName = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lPhone = new System.Windows.Forms.Label();
            this.btnAddClientToDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(26, 28);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(205, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(23, 12);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(26, 13);
            this.lFirstName.TabIndex = 1;
            this.lFirstName.Text = "Imię";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(26, 83);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(205, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(23, 67);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(53, 13);
            this.lLastName.TabIndex = 3;
            this.lLastName.Text = "Nazwisko";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(26, 133);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(205, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(26, 117);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(32, 13);
            this.lEmail.TabIndex = 5;
            this.lEmail.Text = "Email";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(26, 184);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(205, 20);
            this.tbPhone.TabIndex = 6;
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(26, 168);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(43, 13);
            this.lPhone.TabIndex = 7;
            this.lPhone.Text = "Telefon";
            // 
            // btnAddClientToDB
            // 
            this.btnAddClientToDB.Location = new System.Drawing.Point(64, 229);
            this.btnAddClientToDB.Name = "btnAddClientToDB";
            this.btnAddClientToDB.Size = new System.Drawing.Size(122, 23);
            this.btnAddClientToDB.TabIndex = 8;
            this.btnAddClientToDB.Text = "Dodaj nowego klienta";
            this.btnAddClientToDB.UseVisualStyleBackColor = true;
            this.btnAddClientToDB.Click += new System.EventHandler(this.btnAddClientToDB_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 269);
            this.Controls.Add(this.btnAddClientToDB);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddClient";
            this.Text = "Dodaj nowego klienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Button btnAddClientToDB;
    }
}