using LinqLab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Lessons.Queries
{
    public class GroupingRun
    {
        public static void Run()
        {
            var data = SampleData.GetTeam();

            //Deferred Execution
            var resultGroupBy = data.GroupBy(p => p.Country);
            foreach (var Contry in resultGroupBy)
            {
                Console.WriteLine($"Contry Group: {Contry.Key}");

                foreach (var item in Contry)
                {
                    Console.WriteLine($"Team Name: {item.Name}");
                }

                Console.WriteLine("-----------");
            }

            //Immediate Execution
            //There is no difference in output from GroupBy, the only difference is in Deferred Execution and Immediate Execution.
            var result = data.ToLookup(p => p.Country);
        }
    }
}
