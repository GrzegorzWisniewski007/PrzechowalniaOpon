﻿namespace PrzechowalniaOpon
{
    partial class Logs
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
            this.tBLogs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tBLogs
            // 
            this.tBLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBLogs.Location = new System.Drawing.Point(12, 12);
            this.tBLogs.Multiline = true;
            this.tBLogs.Name = "tBLogs";
            this.tBLogs.ReadOnly = true;
            this.tBLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBLogs.Size = new System.Drawing.Size(635, 501);
            this.tBLogs.TabIndex = 0;
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 525);
            this.Controls.Add(this.tBLogs);
            this.Name = "Logs";
            this.Text = "Logi";
            this.Load += new System.EventHandler(this.Logs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBLogs;
    }
}