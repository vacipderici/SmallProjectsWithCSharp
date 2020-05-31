using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread
{
    public partial class Form1 : Form
    {
        //ThreadClass Aynı anda birden fazla işlem yapabilmenizi sağlayan bir sınıftır.
        //Birden fazla iş parçacığını yürütmek için, Thread Class kullanılmalıdır.
        public Form1()
        {
            InitializeComponent();

            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnThread_Click(object sender, EventArgs e)
        {

        }
        public void ProgresDoldur(ProgressBar prgBar,Label lbl,int min,int max, int incrase)
        {
            prgBar.Minimum = min;
            prgBar.Maximum = max;
            prgBar.Step = 5;
            for (int i = prgBar.Maximum; i < prgBar.Maximum; i= incrase)
            {
                prgBar.Value = i;
                lbl.Text = i.ToString();

            }
            
        }
    }
}
