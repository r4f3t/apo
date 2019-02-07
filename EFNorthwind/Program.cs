using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNorthwind
{
    class Program
    {
        
        static void Main(string[] args)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            //var categories = db.Categories;
            //foreach (var item in categories)
            //{
            //    Console.WriteLine(item.CategoryName+" "+item.Description);
            //}
            //var categories = db.Categories.Select(x => new
            //{
            //    Id = x.CategoryID,
            //    Name = x.CategoryName
            //});
            ////ConsoleTable(categories);

          //  var categories = db.Categories.Include("Products").Include("Products.Supplier").FirstOrDefault(x=>x.CategoryID==1);
            //var products = categories.Products.Where(x=>x.ProductID>0).ToList();

            var categories = db.Categories.Select(x=>new {Id=x.CategoryID,Adı=x.CategoryName}).Where(x=>x.Id>=5).OrderBy(x=>x.Adı);
            
            foreach (var item in categories)
            {
                Console.WriteLine(item.Adı);
            }

            //ConsoleTable.From(products).Write();
            Console.ReadKey();
        }
    }
}
