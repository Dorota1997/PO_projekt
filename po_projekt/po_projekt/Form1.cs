using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace po_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Przycisk graj (klikniecie)
        private void play_button_Click(object sender, EventArgs e)
        {
            MEMO przejscie = new MEMO();      // stworzenie obiektu Form2 (formularza 2)
            this.Hide();                        // sposob aby ukryc biezace okno (czyli menu)
            przejscie.Show();                   // sposob aby otworzyc okno z Form2 
        }
        #endregion
        #region Przycisk wyjście (kliknięcie)
        private void wyjdz_z_gry(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
