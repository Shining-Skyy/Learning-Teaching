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
    }
}
