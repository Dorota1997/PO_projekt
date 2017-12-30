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
            Wprowadz_elementy_do_kwadratow();
        }

        private void klik(object sender, EventArgs e)
        {
            if (pierwszy_klik != null && drugi_klik != null)
                return;

            Label klik = sender as Label;

            if (klik == null)
                return;

            if (klik.ForeColor == Color.Black)
                return;

            if (pierwszy_klik == null)
            {
                pierwszy_klik = klik;
                pierwszy_klik.ForeColor = Color.Black;
                return;
            }

            drugi_klik = klik;
            drugi_klik.ForeColor = Color.Black;

            Sprawdz_zwyciestwo();

            if (pierwszy_klik == drugi_klik)
            {
                pierwszy_klik = null;
                drugi_klik = null;
            }

            else
            {
                timer1.Start();
            }
              
        }

        private void Sprawdz_zwyciestwo()
        {
            Label label;
            
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;

            }
            MessageBox.Show("Odkryłeś wszystkie obrazki. Gratuulacje!");
            Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            pierwszy_klik.ForeColor = pierwszy_klik.BackColor;
            drugi_klik.ForeColor = drugi_klik.BackColor;

            pierwszy_klik = null;
            drugi_klik = null;

        }

        private void Wprowadz_elementy_do_kwadratow()
        {
            Label label;
            int losowy_element;

            for(int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                    continue;

                losowy_element = random.Next(0, ikonki.Count);
                label.Text = ikonki[losowy_element];

                ikonki.RemoveAt(losowy_element);
            }
        }
        
    }
}
