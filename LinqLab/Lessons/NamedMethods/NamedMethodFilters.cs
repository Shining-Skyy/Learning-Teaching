using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Lessons.NamedMethods
{
    public static class NamedMethodFilters
    {
        public static bool FindAmazon(Company company)
        {
            return company.Name == "amazon";
        }
    }
}
