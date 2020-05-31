using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipDonusumleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImplicint_Click(object sender, EventArgs e)
        {
            byte degisken1 = 20;
            int degisken2;
            degisken2 = degisken1;
            MessageBox.Show(degisken2.ToString());
        }

        private void btnExplicit_Click(object sender, EventArgs e)
        {
            int degisken1 = 125;
            //byte degisken2=degisken1 //C#bu tip dönüşümüne izin vermez.
            byte degisken2 = (byte)degisken1;
            MessageBox.Show($"Rakam:{degisken1} iken \n  {degisken2} olarak dönüştü.");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            object obj = 123456;
            int Rakam = Convert.ToInt32(obj);
            MessageBox.Show(Rakam.ToString());
        }

        private void btnToString_Click(object sender, EventArgs e)
        {
            DateTime dte = Convert.ToDateTime("17.11.1976");
            MessageBox.Show(
                dte.ToLongDateString() + "\n" +
                dte.ToShortTimeString() + "\n" +
                dte.ToString()
                ); 
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string metinAmaRakam = "54353543";
            int rakam = int.Parse(metinAmaRakam);
            MessageBox.Show(rakam.ToString());
        }

        private void btnTryParse_Click(object sender, EventArgs e)
        {
            string metinAmaRakam = "23213212";
            bool rakam = int.TryParse(metinAmaRakam, out int rakamSonuc);
            MessageBox.Show(rakamSonuc.ToString());
        }

        private void btnAs_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Gold;
        }
    }
}
