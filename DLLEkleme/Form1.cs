using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryUsing;

namespace DLLEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCiftMi_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            checkBox1.Checked = sayi.isCift();
            checkBox1.Checked = sayi.isCift();
            checkBox1.Text = sayi.isCift() ? "Çift" : "Tek";
         }

        private void btnSayiMi_Click(object sender, EventArgs e)
        {
            string rakam = textBox2.Text;
            checkBox2.Checked = rakam.isNumeric();
            checkBox2.Text = rakam.isNumeric() ? "Rakam" : "Rakam Değil";

        }
    }
}
