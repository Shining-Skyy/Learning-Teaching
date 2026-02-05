using LinqLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Data
{
    public static class SampleData
    {
        public static List<Cource> GetCources()
        {
            List<Cource> cources = new List<Cource>()
            {
                new Cource { Id = 1, Name= "C#", Price = 380},
                new Cource { Id = 2, Name= "Python", Price = 210},
                new Cource { Id = 3, Name= "Java", Price = 100},
                new Cource { Id = 4, Name= "JavaScript", Price = 150},
                new Cource { Id = 5, Name= "PHP", Price = 200},
            };

            return cources;
        }

        public static List<Team> GetTeam()
        {
            List<Team> teams = new List<Team>()
            {
                new Team { Name = "Perspolis", Country = "Iran"},
                new Team { Name = "Esteghlal", Country = "Iran"},
                new Team { Name = "Psg", Country = "France"},
                new Team { Name = "Arsenal", Country = "England"},
                new Team { Name = "Manchester", Country = "England"},
                new Team { Name = "Real Madrid", Country = "Spain"}
            };

            return teams;
        }

        private static readonly List<Category> Categories = new()
        {
            new Category { Id = 1, Name = "Mobile" },
            new Category { Id = 2, Name = "LapTop" }
        };

        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, CategoryId = 1, Name = "Iphone" },
            new Product { Id = 2, CategoryId = 1, Name = "Sumsoung" },
            new Product { Id = 3, CategoryId = 2, Name = "Hp" },
            new Product { Id = 4, CategoryId = 2, Name = "Dell" },
        };

        // Returns products with their category name (Inner Join)
        public static IEnumerable<dynamic> GetProductsWithCategory()
        {
            return Products.Join(Categories,
                p => p.CategoryId,
                c => c.Id,
                (product, category) => new
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    CategoryName = category.Name
                });
        }

        // Returns categories with their list of products (Group Join / Left Join style)
        public static IEnumerable<(int CategoryId, string CategoryName, IEnumerable<Product> Products)> GetCategoriesWithProducts()
        {
            return Categories.GroupJoin(Products,
                c => c.Id,
                p => p.CategoryId,
                (category, productGroup) =>
                    (category.Id, category.Name, productGroup));
        }
    }
}
