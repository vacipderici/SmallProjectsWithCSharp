using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explicit_Bilincli_Donusum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Derleyincinin izin vermediği dönüşümlerde kullanılır.ZOrlama yapar.
        //C# tür dönüştürme de bilinçli tür dönüşümleri genelde C# ın izin vermediği dönüşümleri sağlamak için yapılır.
        private void btnExplicint_Click(object sender, EventArgs e)
        {
            int a = 5;
            byte b = (byte)a;
            MessageBox.Show(a.ToString());
        }
    }
}
