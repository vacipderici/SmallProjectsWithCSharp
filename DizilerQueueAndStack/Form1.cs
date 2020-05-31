using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizilerQueueAndStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }

        Queue kuyruk = new Queue();
        Stack yigin = new Stack();

        private void btnStackQueue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEklenecekVeri.Text)&&
                !kuyruk.Contains(txtEklenecekVeri.Text.Trim()))
                
            {
                lblStack.Items.Clear();
                lblQueue.Items.Clear();
                kuyruk.Enqueue(txtEklenecekVeri.Text.Trim());
                yigin.Push(txtEklenecekVeri.Text.Trim());
                foreach (string item in kuyruk)
                {
                    lblQueue.Items.Add(item);
                }
                foreach (string item in yigin)
                {
                    lblStack.Items.Add(item);
                }
            }
            else if(kuyruk.Contains(txtEklenecekVeri.Text.Trim()))
            {
                MessageBox.Show("Kuyrukta"+txtEklenecekVeri.Text+"zaten var");
            }
            else if (string.IsNullOrWhiteSpace(txtEklenecekVeri.Text))
            {
                MessageBox.Show("Boş veri ekleyemezsiniz" );
            }
            txtEklenecekVeri.ResetText();
            txtEklenecekVeri.Focus();

            MessageBox.Show("Sıradaki elemanı ver ama silme:"+"Queue:" + kuyruk.Peek().ToString());
            MessageBox.Show("Sıradaki elemanı verir sonra siler:" + "Queue:" + kuyruk.Dequeue().ToString());

            MessageBox.Show("Sıradaki elemanı ver ama silme:" + "Stack:" + yigin.Peek().ToString());

            MessageBox.Show("Sıradaki elemanı ver ama silme:" + "Stack:" + yigin.Pop().ToString());


        }
    }
}
