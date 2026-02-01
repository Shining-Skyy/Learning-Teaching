using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Lessons.NamedMethods
{
    public static class PredicateRun
    {
        public static void Run()
        {
            var companies = new List<Company>
        {
            new() { Id = 1, Name = "microsoft" },
            new() { Id = 2, Name = "amazon" },
            new() { Id = 3, Name = "google" }
        };
            //Named Methode
            var M_Company = companies.Where(FindCompany);

            //Anynimous Methode
            var A_Company = companies.Where(delegate (Company company)
            {
                return company.Name.StartsWith("a");
            });

            //Lambda Expersion
            var G_Company = companies.Where(company => company.Name.StartsWith("g"));

            var allCompanies =
                M_Company
                .Concat(A_Company)
                .Concat(G_Company);
            foreach (var company in allCompanies)
            {
                Console.WriteLine($"{company.Id} - {company.Name}");
            }
        }

        private static bool FindCompany(Company arg)
        {
            return arg.Name == "microsoft";
        }
    }
}
