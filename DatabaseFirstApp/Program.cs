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
            NorthwindEntities3 db = new NorthwindEntities3();
            //NorthwindEntities1 db = new NorthwindEntities1();
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

            //var result = from c in db.Categories
            //             join p in db.Products
            //             on c.CategoryID equals p.CategoryID
            //             select new
            //             {
            //                 p.ProductName,
            //                 c.CategoryName
            //             };

            //var result = from c in db.Categories
            //             join p in db.Products
            //             on c.CategoryID equals p.CategoryID
            //             orderby p.UnitPrice descending
            //             select new
            //             {
            //                 p.ProductName,
            //                 c.CategoryName,
            //                 p.UnitPrice
            //             };

            //var result = from p in db.Products
            //             group p by p.CategoryID into g
            //             select new
            //             {
            //                 g.Key,
            //                 NumberOfProducts = g.Count()
            //             };

            //var result = from p in db.Products
            //             join c in db.Categories
            //             on p.CategoryID equals c.CategoryID
            //             group c by c.CategoryName into g
            //             select new
            //             {
            //                 g.Key,
            //                 NumberOfProducts = g.Count()
            //             };


            //var result = from p in db.Products
            //             join c in db.Categories
            //             on p.CategoryID equals c.CategoryID
            //             group new { c ,p } by new { c.CategoryName } into g
            //             select new
            //             {
            //                 g.Key.CategoryName,
            //                 NumberOfProducts = g.Count(),
            //                 TotalPrice=g.Sum(x=>x.p.UnitPrice),
            //                 MaxPrice=g.Max(x=>x.p.UnitPrice),
            //                 MinPrice=g.Min(x=>x.p.UnitPrice)

            //             };

            //var result =( from p in db.Products
            //             join c in db.Categories
            //             on p.CategoryID equals c.CategoryID
            //             group new { c, p } by new { c.CategoryName } into g
            //             select new
            //             {
            //                 g.Key.CategoryName,
            //                 NumberOfProducts = g.Count(),
            //                 TotalPrice = g.Sum(x => x.p.UnitPrice),
            //                 MaxPrice = g.Max(x => x.p.UnitPrice),
            //                 MinPrice = g.Min(x => x.p.UnitPrice)

            //             }).Where(x=>x.TotalPrice>300);

            //ConsoleTable.From(result).Write();

            //var category = db.Categories.Find(1);
            //var products = db.Products.Where(x => x.CategoryID == category.CategoryID);
            //var products = category.Products;
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.ProductName);
            //    Console.WriteLine("supplier" + product.Supplier.CompanyName);
            //}

            //var category = db.Categories.Include("Products").Include("Products.Supplier").FirstOrDefault(x => x.CategoryID == 1);
            //var products = category.Products;
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.ProductName);
            //    Console.WriteLine(product.Supplier.CompanyName);
            //}


            //var products = db.Products.OrderBy(x => x.CategoryID).ThenBy(x=>x.ProductName).Select(x => new
            //{
            //    x.CategoryID,
            //    x.ProductName

            //});

            //var products = db.Products.OrderBy(x => x.CategoryID).Skip(5).Take(5).Select(x => new
            //{
            //    x.CategoryID,
            //    x.ProductName

            //});

            //var result = db.Products.All(x => x.UnitPrice>0);
            //var result = db.Products.Any(x => x.UnitPrice > 1000);


            //var result = db.Products.Single(x => x.ProductID == 1);

            //var result = db.Products.SingleOrDefault(x => x.ProductID == 1000);

            //var result = db.Products.First(x => x.CategoryID == 1);

            var result = db.Products.FirstOrDefault(x => x.ProductID == 1);
            Console.WriteLine(result);
            //ConsoleTable.From(products).Write();
            Console.ReadKey();
        }
    }
}
