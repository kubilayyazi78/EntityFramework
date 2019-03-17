using ConsoleTables;
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

            //var result = db.Categories;

            //var result = from cat in db.Categories select cat; //linq
            //ConsoleTable.From(result).Write();


            //var result = db.Categories.Select(x => new
            //{
            //    Id = x.CategoryID,
            //    Name = x.CategoryName
            //});

            //var result = from cat in db.Categories
            //             select new
            //             {
            //                 Id = cat.CategoryID,
            //                 Name = cat.CategoryName
            //             };

            //ConsoleTable.From(result).Write();

            //var result = db.Categories.Take(2);


            //var result = db.Categories.OrderBy(x => x.CategoryName);
            //var result = db.Categories.OrderByDescending(x => x.CategoryName);

            //var result = db.Categories.Where(x => x.CategoryID < 5);

            //var result = db.Categories.Where(x => x.CategoryID ==1 || x.CategoryID==3);

            // var result = db.Categories.Sum(x => x.CategoryID);

            // Console.WriteLine(result);
            // ConsoleTable.From(result).Write();

            //var result = db.Categories.Select(x => new
            //{
            //    Id=x.CategoryID,
            //    IdKara=x.CategoryID*x.CategoryID
            //});

            //var result = db.Categories.Where(x => x.CategoryName.Contains("ro"));

            //var result = db.Categories.Where(x => x.CategoryName.StartsWith("pr"));

            //var result = db.Categories.Where(x => x.CategoryName.EndsWith("ts"));

            //ConsoleTable.From(result).Write();
            Console.ReadKey();
        }
    }
}
