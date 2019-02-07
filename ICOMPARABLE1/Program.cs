using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICOMPARABLE1
{
    class Program
    {
        class OGRENCI:IComparable
        {
            public string Adi { get; set; }
            public short No { get; set; }
            public DateTime DogumTarih { get; set; }

            public int CompareTo(object obj)
            {
                //artan için base>obj 1   else 0
                OGRENCI _ogrenci = (OGRENCI)obj;
                if (this.DogumTarih>_ogrenci.DogumTarih)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            public override string ToString()
            {
                return String.Format("{0}     {1}    {2}", Adi, No.ToString(), DogumTarih.ToLongDateString());
            }
        }

        static void Main(string[] args)
        {
            List<OGRENCI> list = new List<OGRENCI>()
            {
                new OGRENCI{ Adi="Rafet",No=614,DogumTarih=Convert.ToDateTime("1995-09-25")},
                new OGRENCI{ Adi="Serenay",No=1251,DogumTarih=Convert.ToDateTime("2002-09-02")},
                new OGRENCI{ Adi="jade",No=100,DogumTarih=Convert.ToDateTime("1994-01-15")}
            };

            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();

        }
    }
}
