using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var item in GetgUnler())
            {
                Console.WriteLine(item);
                
            }

            foreach (var item in GetgUnler())
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }


        public static IEnumerable<string> GetgUnler()
        {
            yield return "Pazartesi";
            yield return "Salı";
            yield return "Çarşamba";
            yield return "Perşembe";
            yield return "Cuma";
            yield return "Cumartesi";
            yield return "Pazar";


        }
    }
}
