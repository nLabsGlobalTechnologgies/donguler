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
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }
        int pbar = 0;

        private void btPositive_Click(object sender, EventArgs e)
        {
            if (progres.Value != 100)
            {
                progres.Value = pbar + 10;
                pbar = progres.Value;
            }
            else
            {
                MessageBox.Show("Zaten 100");
            }
        }

        private void btNegative_Click(object sender, EventArgs e)
        {
            if (progres.Value != 0)
            {
                progres.Value = pbar - 10;
                pbar = progres.Value;
            }
            else
            {
                MessageBox.Show("Zaten 0");
            }
        }
    }
}
