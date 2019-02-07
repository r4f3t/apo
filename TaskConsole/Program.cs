using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskConsole
{
    class Program
    {
        static void EkranaYazdir(string taskAdi)
        {
            for (int k = 0; k < 100; k++)
            {
                Console.WriteLine(taskAdi + " - " + k);
                Thread.Sleep(50);
            }
        }
        private static bool UcakBiletiAl()
        {
            Console.WriteLine("Ucak bileti alınıyor...");
            Thread.Sleep(1000);
            Console.WriteLine("Ucak bileti alındı...");
            return true;
        }

        private static void OtelReservasyonuYap()
        {
            Console.WriteLine("Otel reservasyonu yapılıyor...");
            Thread.Sleep(3000);
            Console.WriteLine("Otel reservasyonu yapıldı");
        }

        private static void AracKirala()
        {
            Console.WriteLine("Arac kiralanıyor...");
            Thread.Sleep(2000);
            Console.WriteLine("Arac kiralandı");
        }
        static async Task<string> Indir() {
            Thread.Sleep(3000);
            WebRequest request = WebRequest.Create("https://jsonplaceholder.typicode.com/comments");
            request.Method = "GET";
            WebResponse response = await request.GetResponseAsync();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string icerik = reader.ReadToEnd();
            reader.Close();
            response.Close();
            return icerik;
        }
        static void StartDownloading()
        {
            Task<string> _task = Indir();
            Console.WriteLine("asynchronous downloading has been started.");
            Console.WriteLine(_task.Result);
            Console.WriteLine("asynchronous downloading has been finished");
        }
        static void Main(string[] args)
        {
            //Stopwatch sw = Stopwatch.StartNew();
            //Task<bool> FirstWork = Task<bool>.Factory.StartNew(() => UcakBiletiAl());
            //Task SecondWork = Task.Factory.StartNew(() => OtelReservasyonuYap());
            //Task ThirdWork = Task.Factory.StartNew(() => AracKirala());
            //Task.WaitAll(FirstWork, SecondWork, ThirdWork);
            ////UcakBiletiAl();
            ////OtelReservasyonuYap();
            ////AracKirala();
            //Console.WriteLine(FirstWork.Result);
            //Console.WriteLine("{0} saniye sürdü", sw.ElapsedMilliseconds / 1000.0);
            Task indirTSK=Task.Factory.StartNew(()=> StartDownloading());
            Console.WriteLine("Line Read");
            Console.ReadLine();
        }
    }
}
