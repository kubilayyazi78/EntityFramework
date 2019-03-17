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
            //var sales = db.Sales_by_Year(new DateTime(1997, 1, 1), DateTime.Now);
            //foreach (var sale in sales)
            //{
            //    Console.WriteLine(sale.Year + "/" + sale.Subtotal);
            //}

            //create

            //var category = new Category();
            //category.CategoryName = "Çerez";
            //category.Description = "Fındık";
            //db.Categories.Add(category);
            //db.SaveChanges();

            //read 

            //var categories = db.Categories;
            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category.CategoryName + "//" + category.Description);
            //}

            //update

            //var category = db.Categories.Find(9);
            //category.CategoryName = "içecekler";
            //category.Description = "kola";
            //db.SaveChanges();

            //delete

            //var category = db.Categories.Find(9);
            //db.Categories.Remove(category);
            //db.SaveChanges();
            Console.ReadKey();
        }
    }
}
