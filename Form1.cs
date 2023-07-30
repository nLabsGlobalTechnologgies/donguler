using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pbar = 0;

        private void btPositive_Click(object sender, EventArgs e)
        {
            if (progres.Value != progres.Maximum)
            {
                progres.Value = pbar + 10;
                pbar = progres.Value;
            }
            else
            {
                MessageBox.Show($"Zaten {progres.Maximum} daha fazla olamaz");
            }
        }

        private void btNegative_Click(object sender, EventArgs e)
        {
            if (progres.Value != progres.Minimum)
            {
                progres.Value = pbar - 10;
                pbar = progres.Value;
            }
            else
            {
                MessageBox.Show($"Zaten {progres.Minimum} daha az olamaz");
            }
        }
    }
}
