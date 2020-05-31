using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizilerGenericDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> icindekiler = new Dictionary<int, string>();
            icindekiler.Add(0, "Generic");
            icindekiler.Add(5, "List<>");
            icindekiler.Add(2, "Dictionary<>");
            icindekiler.Add(4, "SortedList<>");
            icindekiler.Add(3, "Stack<>");
            icindekiler.Add(1, "Queue");

            StringBuilder sbd = new StringBuilder();
            foreach (KeyValuePair<int,string> item in icindekiler)
            {
                sbd.Append(item.Key);
                sbd.Append("-");
                sbd.Append(item.Value);
                sbd.AppendLine();
            }
            MessageBox.Show(sbd.ToString());
        }
    }
}
