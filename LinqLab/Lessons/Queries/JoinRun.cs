using LinqLab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Lessons.Queries
{
    public class JoinRun
    {
        public static void Run()
        {
            //Inner Join
            Console.WriteLine("=== Inner Join: Product → Category ===\n");

            var productsWithCategory = SampleData.GetProductsWithCategory();

            foreach (var item in productsWithCategory)
            {
                Console.WriteLine($"{item.ProductName,-12} = {item.CategoryName}");
            }

            Console.WriteLine("\n");

            //Group Join
            Console.WriteLine("=== Group Join: Category → List of Products ===\n");

            var categoriesWithProducts = SampleData.GetCategoriesWithProducts();

            foreach (var item in categoriesWithProducts)
            {
                Console.WriteLine($"Category: {item.CategoryName} (ID: {item.CategoryId})");

                if (!item.Products.Any())
                {
                    Console.WriteLine("No products in this category");
                }
                else
                {
                    foreach (var p in item.Products)
                    {
                        Console.WriteLine($"{p.Name} (ID: {p.Id})");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
