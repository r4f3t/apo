using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNorthwindCodeFirst
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class MoviesContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public MoviesContext():base("MoviesConnection")
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MoviesContext db = new MoviesContext();
            var category = new Category()
            {
                Description = "desc 1",
                Name = "Category 1"
            };
            db.Categories.Add(category);
            db.SaveChanges();
        }
    }
}
