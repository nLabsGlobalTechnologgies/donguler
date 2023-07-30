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
    public partial class frmPasta : Form
    {
        public frmPasta()
        {
            InitializeComponent();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            p1.Value += 10;
            if (p1.Value % 20 == 10)
            {
                l1.BackColor = Color.Red;
            }
            if (p1.Value % 20 == 0)
            {
                l1.BackColor = Color.Green;
            }
            if (p1.Value == 100)
            {
                t1.Stop();
                l1.Text = "İşlem tamamlandı";
                t2.Start();
            }
        }

        private void t2_Tick(object sender, EventArgs e)
        {
            p2.Value += 10;
            if (p2.Value % 20 == 10)
            {
                l2.BackColor = Color.Red;
            }
            if (p2.Value % 20 == 0)
            {
                l2.BackColor = Color.Green;
            }
            if (p2.Value == 100)
            {
                t2.Stop();
                l2.Text = "İşlem tamamlandı";
                t3.Start();
            }
        }

        private void t3_Tick(object sender, EventArgs e)
        {
            p3.Value += 10;
            if (p3.Value % 20 == 10)
            {
                l3.BackColor = Color.Red;
            }
            if (p3.Value % 20 == 0)
            {
                l3.BackColor = Color.Green;
            }
            if (p3.Value == 100)
            {
                t3.Stop();
                l3.Text = "İşlem tamamlandı";
                t4.Start();
            }
        }

        private void t4_Tick(object sender, EventArgs e)
        {
            p4.Value += 10;
            if (p4.Value % 20 == 10)
            {
                l4.BackColor = Color.Red;
            }
            if (p4.Value % 20 == 0)
            {
                l4.BackColor = Color.Green;
            }
            if (p4.Value == 100)
            {
                t4.Stop();
                l4.Text = "İşlem tamamlandı";
                MessageBox.Show("Pastanız Hazır Afiyet Olsun");
            }
        }
    }
}
