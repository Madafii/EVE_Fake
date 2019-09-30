﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVE_Fake
{
    public partial class New_Character : Form
    {
        public New_Character()
        {
            InitializeComponent();
        }

        private void tbxCharName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Character erstellen
            string char_name = tbxCharName.Text;
            double starter_Kapital = Convert.ToDouble(tbxStartKapital.Text);
            string erstes_Raumschiff = clbNewCharRaumschiffe.Text;

            Character char1 = new Character(char_name, starter_Kapital, erstes_Raumschiff);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            //Menue beim abbrechen
            this.Hide();

            frmMenue menue = new frmMenue();

            menue.Closed += (s, args) => this.Close();
            menue.Show();
        }
    }
}
