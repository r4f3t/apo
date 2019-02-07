using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBProcer.Models;
using System.Data.SqlClient;
namespace DBProcer
{
    class Program
    {
        static void Main(string[] args)
        {

            UserModel userModel = new UserModel(1, "Rafet", "1111", "Seyhan / Adana");
            USERAdd userAdd = new USERAdd(new NormalUser(userModel));
            userAdd.writeToDb();

            userModel = new UserModel(2, "admin", "1111", "Niance / Lyonnais France");
            userAdd = new USERAdd(new AdminUser(userModel));
            userAdd.writeToDb();

            LinqSorgu();
            Console.ReadKey();
        }

        delegate int SayiIslevi(int x, int y);
        //link denemeleri
        private static void LinqSorgu()
        {
            var liste = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var tekler = from sayi in liste
            //             where sayi % 2 == 1 select sayi;
            SayiIslevi sayiIslevi = (x, y) => x + y;
            Console.WriteLine(sayiIslevi(3, 5));
            var tekler = liste.Where(sayi => sayi % 2 == 1);
            foreach (var item in tekler)
            {
                Console.WriteLine(item.ToString());
            }

            var listUser = new List<UserModel>
            {
                new UserModel{Name="rafet",Adress="Adana",AUTHORITY=1},
                new UserModel{Name="Daniel",Adress="Ostrava",AUTHORITY=2},
                new UserModel{Name="Jade",Adress="Lyonnais",AUTHORITY=2}
            };
            /* var sorted = from veri in listUser
                          where veri.AUTHORITY == 2
                          orderby veri.Name descending
                          select veri;*/
            var sorted = listUser.Where(a => a.AUTHORITY == 2).OrderByDescending(a=>a.Name);

            foreach (var item in sorted)
            {
                Console.WriteLine(item.Name);
            }

        }
    }

}
