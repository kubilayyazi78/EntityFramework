using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities1 db = new NorthwindEntities1();
            var categories = db.Categories;
            foreach (var cat in categories)
            {
                Console.WriteLine(cat.CategoryName);
            }
            Console.ReadKey();
        }
    }
}
