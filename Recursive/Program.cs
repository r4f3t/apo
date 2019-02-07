using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        static int Faktoryel(int i)
        {
            if (i==0)
            {
                return 1;
            }
            return i * Faktoryel(i - 1);
        }

        static int Fibo(int sayi) {
            if (sayi==0 || sayi==1)
            {
                return 1;
            }
            return Fibo(sayi - 1) + Fibo(sayi-2);
        }
        static void Main(string[] args)
        {
            string _sayi = Console.ReadLine() ;
            Console.WriteLine(Faktoryel(Convert.ToInt32(_sayi)));
            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine(Fibo(i).ToString());
            }
            Console.ReadKey();
        }
    }
}
