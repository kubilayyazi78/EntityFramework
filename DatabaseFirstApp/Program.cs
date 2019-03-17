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
            //var products = db.Ten_Most_Expensive_Products();
            //foreach (var pro in products)
            //{
            //    Console.WriteLine(pro.TenMostExpensiveProducts + "/" + pro.UnitPrice);
            //}
            //var categories = db.Categories;
            //foreach (var cat in categories)
            //{
            //    Console.WriteLine(cat.CategoryName);
            //}
            var sales = db.Sales_by_Year(new DateTime(1997, 1, 1), DateTime.Now);
            foreach (var sale in sales)
            {
                Console.WriteLine(sale.Year+"/"+sale.Subtotal);
            }
            Console.ReadKey();
        }
    }
}
