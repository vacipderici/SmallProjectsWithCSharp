using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigerVeriTipleriNullbleGuid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNullable_Click(object sender, EventArgs e)
        {
            int? rakam = null;
            if (rakam.HasValue)
            {
                MessageBox.Show(rakam.Value.ToString());
            }
            else
            {
                MessageBox.Show(rakam.GetValueOrDefault(123).ToString());
            }
        }

        private void btnGuid_Click(object sender, EventArgs e)
        {
            string idUret = Guid.NewGuid().ToString("N");
            MessageBox.Show(idUret);
        }
    }
}
