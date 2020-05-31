using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Implicint_BilincsizTurDonusumu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //tipini daha önce tanımladığımız bir değişkenin,tipinin geçici olarak başka bir tipe çevrilmesidir. Nesne tipi geçici olaak değiştirilir.Kalıcı değildir.
        
            //Küçük tip büyük veri tipe çevrilirse veir kaybı yaşanmaz. örn byte short.
            //bitler sıfırla beslenir.
        private void btnImplicint_Click(object sender, EventArgs e)
        {
            byte degisken1 = 20;
            int degisken2 ;
            degisken2 = degisken1;
            MessageBox.Show(degisken2.ToString());
        }
    }
}
