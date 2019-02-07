using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                
                list.Add(rand.Next(0,10));
            }
            list=list.OrderBy(x=>x).ToList();
            Console.Write(list.GetHashCode());

            foreach (var item in list)
            {
                Console.WriteLine(item);

            }

            Console.ReadKey();
        }


        static int fak(int n)
        {
            if (n == 1 || n==0)
            {
                return 1;
            }

            return n * fak(n - 1) ;
        }
    }
}
