using LinqLab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Lessons.Queries
{
    public class ProjectionRun
    {
        public static void Run()
        {
            var productsWithCategorySelect = SampleData.GetProductWithCategorySelect();

            foreach (var item in productsWithCategorySelect)
            {
                Console.WriteLine($"{item.ProductName,-12} = {item.CategoryName}");
            }

            Console.WriteLine("-----------");

            var productsWithCategorySelectMany = SampleData.GetProductWithCategorySelectMany();

            foreach (var item in productsWithCategorySelectMany)
            {
                Console.WriteLine($"{item.ProductName,-12} = {item.CategoryName} ({item.Year})");
            }
        }
    }
}
