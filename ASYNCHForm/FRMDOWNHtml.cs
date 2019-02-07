using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASYNCHForm
{
    public partial class FRMDOWNHtml : Form
    {
        public FRMDOWNHtml()
        {
            InitializeComponent();
        }

        private void FRMDOWNHtml_Load(object sender, EventArgs e)
        {
            FRMDOWNHtml.CheckForIllegalCrossThreadCalls = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string data = await DownloadDataAsync();
            textBox1.Text = data;
        }

        async Task<string> DownloadDataAsync() //DownloadDataAsync Task’inin asenkron olduğunu async keyword’ü ile belirtiyoruz. Asenkron kullanmak istediğimiz için Task oluşturduk.
        {   
            WebClient wc = new WebClient(); //WebClient Sınıfından yeni bir WebClient nesnesi türetiliyor…
            string data = await wc.DownloadStringTaskAsync("http://w3schools.com");
            //Ürettiğimiz wc isimli nesnenin DownloadString metoduyla w3schools kaynağındaki html kodlarını çekip değişkene aktarıyoruz
            return data; //Veri kaynağından çektiği verileri tekrar döndürüyor. Böylece bu metodu çağıran yere bu bilgi ulaşmış oluyor.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text += "rafet";
        }
    }
}
