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

        private void play_button_Click(object sender, EventArgs e)
        {
            Form2 przejscie = new Form2();      // stworzenie obiektu Form2 (formularza 2)
            this.Hide();                        // sposob aby ukryc biezace okno (czyli menu)
            przejscie.Show();                   // sposob aby otworzyc okno z Form2 
        }
    }
}
