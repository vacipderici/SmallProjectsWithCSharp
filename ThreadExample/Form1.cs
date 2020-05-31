using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Thread Class; Aynı anda birden fazla işlem yapabilmemizi sağlayan sınıftır;
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false; //Thread Senkranizasyonu için
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            Thread start1 = new Thread(delegate () { ProgressDoldur(progressBar1, label1, 0, 10000, 5); });
            Thread start2 = new Thread(delegate () { ProgressDoldur(progressBar2, label2, 0, 10000, 10); });
            Thread start3 = new Thread(delegate () { ProgressDoldur(progressBar3, label3, 0, 10000, 100); });

            start1.Start();
            start2.Start();
            start3.Start();
        }
        public void ProgressDoldur(ProgressBar prgBar, Label lbl, int min, int max, int incrase)
        {
            prgBar.Minimum = min;
            prgBar.Maximum = max;
            prgBar.Step = 5;
            for (int i = prgBar.Minimum; i <= prgBar.Maximum; i += incrase)
            {
                prgBar.Value = i;
                lbl.Text = i.ToString();
            }
        }
    }
}
