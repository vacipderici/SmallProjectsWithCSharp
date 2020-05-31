using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace ThreadExampleSecond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void ArrayListOrnegi()
        {
            //ArrayList Object Tipinde Veri alır.
            ArrayList arrList = new ArrayList();
            for (int i = 0; i < 90000000; i++)
            {
                arrList.Add("Jack London");
            }
            string sakla;
            //Süre Ölçer başlasın.
            Stopwatch stpWatch = Stopwatch.StartNew();
            foreach (string item in arrList)
            {
                sakla = item;
                stpWatch.Stop();
                MessageBox.Show("ArrayList süresi: " + stpWatch.ElapsedMilliseconds);
                //Metodun çalışma hızını ölçtük  stpWatch.ElapsedMilliseconds
            }
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ArrayListOrnegi();
        }

        public static void GenericListOrnegi()
        {
            //GenericList<string> tipinde veri vereceğim.
            List<string> genericList = new List<string>();

            for (int i = 0; i < 90000000; i++)
            {
                genericList.Add("Jack London");
            }
            string sakla;
            //Süre Ölçer başlasın.
            Stopwatch stpWatch = Stopwatch.StartNew();
            foreach (string item in genericList)
            {
                sakla = item;
                stpWatch.Stop();
                MessageBox.Show("GenericList süresi: " + stpWatch.ElapsedMilliseconds);
                //Metodun çalışma hızını ölçtük  stpWatch.ElapsedMilliseconds
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GenericListOrnegi();
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            Thread start1 = new Thread(ArrayListOrnegi);
            Thread start2 = new Thread(GenericListOrnegi);
            start1.Start();
            start2.Start();
        }
      

    }
}
