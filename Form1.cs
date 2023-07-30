namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam = toplam + i;
            }
            label1.Text = "Toplam Sonuç : " + toplam.ToString();
        }
    }
}