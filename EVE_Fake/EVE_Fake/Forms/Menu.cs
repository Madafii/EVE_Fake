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
    public partial class frmMenu : Form
    {

        public static string IdCharakter;
        
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //hide frm menue
            this.Hide();

            //Neue Form Erzeugen und alte schließen
            New_Character newchar = new New_Character();

            newchar.Closed += (s, args) => this.Close();
            newchar.Show();
        }

        private void btnCharacterOne_Click(object sender, EventArgs e)
        {
            this.Hide();

            IdCharakter = "0";
            frmCharacter_Sheet charSheet = new frmCharacter_Sheet(IdCharakter);

            charSheet.Closed += (s, args) => this.Close();
            charSheet.Show();
        }

        private void btnCharacterTwo_Click(object sender, EventArgs e)
        {
            this.Hide();

            IdCharakter = "1";
            frmCharacter_Sheet charSheet = new frmCharacter_Sheet(IdCharakter);

            charSheet.Closed += (s, args) => this.Close();
            charSheet.Show();
        }
    }
}
