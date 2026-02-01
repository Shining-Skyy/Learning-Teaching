using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Lessons.NamedMethods
{
    public static class NamedMethodRun
    {
        public static void Run()
        {
            var companies = new List<Company>
        {
            new() { Id = 1, Name = "microsoft" },
            new() { Id = 2, Name = "amazon" },
            new() { Id = 3, Name = "google" }
        };

            var result = companies.Where(NamedMethodFilters.FindAmazon);

            foreach (var company in result)
            {
                Console.WriteLine(company.Name);
            }
        }
    }
}
