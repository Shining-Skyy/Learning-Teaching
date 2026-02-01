using LinqLab.Data;
using LinqLab.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Lessons.Queries
{
    public static class FilteringRun
    {
        public static void Run()
        {
            //Filtering/Where
            //The Where method has two overrides. In the first override, a single input is provided and no parentheses are needed. In the second override, to provide two inputs, parentheses must be used.
            var resultWhere = SampleData.GetCources().Where((c, i) =>
            {
                //c.Name = "C#";
                if (i % 2 == 0)
                    return true;

                return false;
            });

            foreach (var course in resultWhere)
            {
                Console.WriteLine($"Id: {course.Id}, Name: {course.Name}, Price: {course.Price}");
            }

            //Filtering/OfType
            IList list = new ArrayList();
            list.Add(7);
            list.Add("Test");
            list.Add(new Cource { Id = 10, Name = "Swift", Price = 50});

            var resultOfType = list.OfType<Cource>();

            foreach (var course in resultOfType)
            {
                Console.WriteLine($"Id: {course.Id}, Name: {course.Name}, Price: {course.Price}");
            }
        }
    }
}
