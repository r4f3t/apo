using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatisDelegate
{
    class Program
    {
        delegate decimal Hesapla(int amount);
        static void Main(string[] args)
        {
            
            Console.WriteLine(SonucHesapla(5,FiyatVer).ToString("N"));
          
            Console.WriteLine(SonucHesapla(5,FiyatVerKdv).ToString("N"));
            Console.ReadKey();
        }
        static decimal SonucHesapla(int Adet, Hesapla h)
        {
            return h(Adet);
        }
        private static decimal FiyatVer(int Adet)
        {
            return 5 * Adet;
        }

        private static decimal FiyatVerKdv(int Adet)
        {
            return 5 * Adet * 2;
        }
    }
}
