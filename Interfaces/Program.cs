using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new BirinciMevzuat());
            customerManager.Add();
            customerManager = new CustomerManager(new IkinciMevzuat());
            customerManager.Add();
            Console.ReadKey();
        }

        class CustomerManager
        {
            private IMevzuat _mevzuat;

            public CustomerManager(IMevzuat mevzuat)
            {
                _mevzuat = mevzuat;
            }

            public void Add()
            {
                _mevzuat.IslemYap();
                //Console.WriteLine("Müşteri Eklendi.");
            }
        }
        interface IMevzuat
        {
            void IslemYap();
        }

        class BirinciMevzuat : IMevzuat
        {
            public void IslemYap()
            {
                Console.WriteLine("Birinci Mevzuata Göre eklendi");
            }
        }

        class IkinciMevzuat : IMevzuat
        {
            public void IslemYap()
            {
                Console.WriteLine("İkinci Mevzuata Göre eklendi");
            }
        }
    }
}
