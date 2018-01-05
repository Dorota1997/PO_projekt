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
            "O", "O", "!", "!", "€", "€", "ł", "ł", "l", "l", "b", "b", "ń", "ń", "ó", "ó"
        };

        Label pierwsze_klikniecie, drugie_klikniecie;

        public Form2()
        {
            InitializeComponent();
            obrazki_do_kwadraciokow();
        }

        private void Klik(object sender, EventArgs e)
        {
            Label KlikLabel = sender as Label;

            if (KlikLabel == null)
            {
                return;
            }

            if (KlikLabel.ForeColor == Color.Black)
            {
                return;
            }

            if (pierwsze_klikniecie == null)
            {
                pierwsze_klikniecie = KlikLabel;
                pierwsze_klikniecie.ForeColor = Color.Black;
                return;
            }


        }

        private void obrazki_do_kwadraciokow()
        {
            Label label;
            int losowy_numer;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                {
                    continue;
                }

                losowy_numer = random.Next(0, ikonki.Count);

                label.Text = ikonki[losowy_numer];

                ikonki.RemoveAt(losowy_numer);
            }
        }
    }
}
