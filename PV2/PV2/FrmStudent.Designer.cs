﻿namespace PV2
{
    partial class FrmStudent
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
            this.LblName = new System.Windows.Forms.Label();
            this.BttPressMe = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(21, 25);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(10, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = ".";
            // 
            // BttPressMe
            // 
            this.BttPressMe.Location = new System.Drawing.Point(12, 41);
            this.BttPressMe.Name = "BttPressMe";
            this.BttPressMe.Size = new System.Drawing.Size(776, 23);
            this.BttPressMe.TabIndex = 1;
            this.BttPressMe.Text = "Presióname";
            this.BttPressMe.UseVisualStyleBackColor = true;
            this.BttPressMe.Click += new System.EventHandler(this.BttPressMe_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(12, 2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(776, 20);
            this.TxtName.TabIndex = 2;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BttPressMe);
            this.Controls.Add(this.LblName);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BttPressMe;
        private System.Windows.Forms.TextBox TxtName;
    }
}