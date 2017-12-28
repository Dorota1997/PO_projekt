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

        public Form2()
        {
            InitializeComponent();
        }

        
    }
}
