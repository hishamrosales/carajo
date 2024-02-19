namespace PV2
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
            this.CmbCarreras = new System.Windows.Forms.ComboBox();
            this.LblCarrera = new System.Windows.Forms.Label();
            this.BttPressMeDos = new System.Windows.Forms.Button();
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
            // CmbCarreras
            // 
            this.CmbCarreras.FormattingEnabled = true;
            this.CmbCarreras.Items.AddRange(new object[] {
            "Ingeniería de Software",
            "Ingeniería Mecatrónica",
            "Diseño Digital",
            "Derecho",
            "Arquitectura"});
            this.CmbCarreras.Location = new System.Drawing.Point(12, 79);
            this.CmbCarreras.Name = "CmbCarreras";
            this.CmbCarreras.Size = new System.Drawing.Size(776, 21);
            this.CmbCarreras.TabIndex = 3;
            this.CmbCarreras.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblCarrera
            // 
            this.LblCarrera.AutoSize = true;
            this.LblCarrera.Location = new System.Drawing.Point(12, 112);
            this.LblCarrera.Name = "LblCarrera";
            this.LblCarrera.Size = new System.Drawing.Size(0, 13);
            this.LblCarrera.TabIndex = 4;
            // 
            // BttPressMeDos
            // 
            this.BttPressMeDos.Location = new System.Drawing.Point(12, 128);
            this.BttPressMeDos.Name = "BttPressMeDos";
            this.BttPressMeDos.Size = new System.Drawing.Size(776, 23);
            this.BttPressMeDos.TabIndex = 5;
            this.BttPressMeDos.Text = "Presióname";
            this.BttPressMeDos.UseVisualStyleBackColor = true;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BttPressMeDos);
            this.Controls.Add(this.LblCarrera);
            this.Controls.Add(this.CmbCarreras);
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
        private System.Windows.Forms.ComboBox CmbCarreras;
        private System.Windows.Forms.Label LblCarrera;
        private System.Windows.Forms.Button BttPressMeDos;
    }
}