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
            if (pierwsze_klikniecie != null && drugie_klikniecie != null)
            {
                return;
            }

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

            drugie_klikniecie = KlikLabel;
            drugie_klikniecie.ForeColor = Color.Black;

            Sprawdz_zwyciezce();

            if (pierwsze_klikniecie.Text == drugie_klikniecie.Text)
            {
                pierwsze_klikniecie = null;
                drugie_klikniecie = null;
            }
            else
            {
                timer1.Start();
            }
        }

        private void Sprawdz_zwyciezce()
        {
            Label label;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                {
                    return;
                }
            }

            MessageBox.Show("Znalazłeś wszystkie pary! Gratulacje! :)");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            pierwsze_klikniecie.ForeColor = pierwsze_klikniecie.BackColor;
            drugie_klikniecie.ForeColor = drugie_klikniecie.BackColor;

            pierwsze_klikniecie = null;
            drugie_klikniecie = null;

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
