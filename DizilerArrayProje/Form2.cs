using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizilerArrayProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] dizi = new string[10];
        int sayac;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstDizi.FindString(txtDizi.Text) == -1 &&

                sayac < dizi.Length &&
                !string.IsNullOrWhiteSpace(txtDizi.Text)  
                )
            {
                dizi[sayac] = txtDizi.Text.Trim();
                lstDizi.Items.Add(dizi[sayac]); sayac++;

            }
            else if (lstDizi.FindString(txtDizi.Text) > -1)
            {
                MessageBox.Show("Dizide"+txtDizi.Text+"zaten var");

            }
            else if (sayac==dizi.Length)
            {
                MessageBox.Show(text: "Diziancak" + dizi.Length + "elaman alabiliyor"); ;
            }
            else if (string.IsNullOrWhiteSpace(txtDizi.Text))
            {
                MessageBox.Show("Boş veri ekleyemezsiniz");
            }
            txtDizi.ResetText();
            txtDizi.Focus();
        }
    }
}
