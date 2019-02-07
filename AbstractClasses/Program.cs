using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Degerlendir();
            aMevzuat.Kaydet();

            CMevzuat cMevzuat = new CMevzuat();
            cMevzuat.Kaydet();
            Console.ReadKey();
        }

        public abstract class MevzuatBase
        {
            protected MevzuatBase()
            {
                Console.WriteLine("MevzuatBase constructed.");
            }
            public abstract void Degerlendir();
            public virtual void Kaydet()
            {
                Console.WriteLine("Kaydedildi.");
            }
        }

        public class AMevzuat : MevzuatBase
        {
            public AMevzuat()
            {
                Console.WriteLine("AMevzuat Constructed");
            }
            //indirgedi her classın kendi baseclass Degerlendiri olacak.
            public override void Degerlendir()
            {
                Console.WriteLine("A classına Göre Değerlendirildi.");
            }
        }

        public class BMevzuat : MevzuatBase
        {
            public BMevzuat()
            {
                Console.WriteLine("BMevzuat Constructed");
            }
            //indirgedi her classın kendi baseclass Degerlendiri olacak.
            public override void Degerlendir()
            {
                Console.WriteLine("BMevzuat classına Göre Değerlendirildi.");
            }
        }

        public class CMevzuat : MevzuatBase
        {
            public CMevzuat()
            {
                Console.WriteLine("CMevzuat Constructed");
            }
            //indirgedi her classın kendi baseclass Degerlendiri olacak.
            public override void Degerlendir()
            {
                Console.WriteLine("CMevzuat classına Göre Değerlendirildi.");
            }

            public override void Kaydet()
            {
                Console.WriteLine("CMevxuatın Kaydeti.");
            }
        }
    }
}
