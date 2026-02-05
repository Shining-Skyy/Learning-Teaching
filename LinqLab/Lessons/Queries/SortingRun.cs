using LinqLab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Lessons.Queries
{
    public static class SortingRun
    {
        public static void Run()
        {
            var resultOrderBy = SampleData.GetCources().OrderBy(p => p.Price);
            Console.WriteLine("____OrderBy____");
            foreach (var item in resultOrderBy)
            {
                Console.WriteLine($"Id = {item.Id} / Name = {item.Name} / Price = {item.Price}");
            }

            var resultThenBy = SampleData.GetCources().OrderBy(p => p.Price).ThenBy(p => p.Id);
            Console.WriteLine("____ThenBy____");
            foreach (var item in resultThenBy)
            {
                Console.WriteLine($"Id = {item.Id} / Name = {item.Name} / Price = {item.Price}");
            }

            var resultOrderByDescending = SampleData.GetCources().OrderByDescending(p => p.Price);
            Console.WriteLine("____OrderByDescending____");
            foreach (var item in resultOrderByDescending)
            {
                Console.WriteLine($"Id = {item.Id} / Name = {item.Name} / Price = {item.Price}");
            }

            var resultThenByDescending = SampleData.GetCources().OrderByDescending(p => p.Price).ThenByDescending(p => p.Id);
            Console.WriteLine("____ThenByDescending____");
            foreach (var item in resultThenByDescending)
            {
                Console.WriteLine($"Id = {item.Id} / Name = {item.Name} / Price = {item.Price}");
            }

            var resultReverse = SampleData.GetCources().OrderByDescending(p => p.Price).ThenByDescending(p => p.Id).Reverse();
            Console.WriteLine("____Reverse____");
            foreach (var item in resultThenByDescending)
            {
                Console.WriteLine($"Id = {item.Id} / Name = {item.Name} / Price = {item.Price}");
            }

            Console.ReadLine();
        }
    }
}
