﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV2
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void BttPressMe_Click(object sender, EventArgs e)
        {
            //estructuras de control
            if (this.TxtName.Text != string.Empty)
            {
                this.LblName.Text = this.TxtName.Text;
            }
            else
            {
                this.LblName.Text = "La caja está vacía";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.CmbCarreras.Text != string.Empty)
            {
                this.LblCarrera.Text = this.CmbCarreras.Text;
            }
            else
            {
                this.LblCarrera.Text = "La combo box esta vacía";
            }
        }
    }
}
