using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstCSharpProject
{
    class Program
    {
        public static void Main(string[] args) {
            List<Product> products = new List<Product>
            {
                new Product("West Side Story", 9.99m, 1),
                new Product("Assassins", 14.99m, 1),
                new Product("Frogs", 11.99m, 2),
                new Product("Sweeney Todd", 10.99m, 3),
            };
            List<Supplier> suppliers = new List<Supplier>
            {
                new Supplier("Penis", 1),
                new Supplier("4len", 2),
                new Supplier("Zalupa", 3),
            };
            var filtered = from p in products
                           join s in suppliers
                           on p.SupplierId equals s.SupplierId
                           orderby s.Name, p.Name
                           select new { SupplierName = s.Name, ProductName = p.Name };
            foreach (var v in filtered)
                Console.WriteLine("Supplier = {0}, Product = {1}", v.SupplierName, v.ProductName);
            //foreach (Product product in products.Where(p => p.Price == null).OrderBy(p => p.Name))
            //{
            //    Console.WriteLine(product.ToString());
            //}
        }
    }
}