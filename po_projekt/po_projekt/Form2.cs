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
    public partial class Form2 : Form
    {
        Random random = new Random();

        List<string> ikonki = new List<string>()
        {
            "b", "b", "f", "f", "H", "H", "N", "N", "!", "!", "$", "$", "O", "O", "v", "v"
        };

        Label pierwszy_klik, drugi_klik;

        public Form2()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            Label label;
            int randomNumer;

            for(int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                    continue;

                randomNumer = random.Next(0, ikonki.Count);
                label.Text = ikonki[randomNumer];

                ikonki.RemoveAt(randomNumer);
            }
        }
        
    }
}
