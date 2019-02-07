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

namespace ASYNCHForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void GetCounted() {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                LBAsynchronous.Items.Add(i.ToString());
            }
        }
        private async void BTNAsenkron_Click(object sender, EventArgs e)
        {
            Task task = Task.Factory.StartNew(() => GetCounted());
        }

        private void BTNNormal_Click(object sender, EventArgs e)
        {
            LBNormal.Items.Add("Kayit");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
