using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class GroupBy : Base
    {
        public override string ToString()
        {
            return "GroupBy";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var groupBy = new GroupBy();
                Utilities.PrintStart(groupBy.ToString());
                var persons = new[] {
                new { Name="Fizz", Job="Developer"},
                new { Name="Buzz", Job="Developer"},
                new { Name="Foo", Job="Astronaut"},
                new { Name="Bar", Job="Astronaut"},
                };
                var groupedByJob = persons.GroupBy(p => p.Job);
                foreach (var theGroup in groupedByJob)
                {
                    Console.WriteLine(
                    "{0} are {1}s",
                    string.Join(",", theGroup.Select(g => g.Name).ToArray()),
                    theGroup.Key);
                }
                //Fizz,Buzz are Developers
                //Foo,Bar are Astronauts

                //var a = db.Invoices.GroupBy(i => i.Country)
                //.Select(g => new {
                //    Country = g.Key,
                //    Count = g.Count(),
                //    Total = g.Sum(i => i.Paid),
                //    Average = g.Average(i => i.Paid)
                //});

                //var a = db.Invoices.GroupBy(i => 1)
                //.Select(g => new {
                //    Count = g.Count(),
                //    Total = g.Sum(i => i.Paid),
                //    Average = g.Average(i => i.Paid)
                //});

                //var a = db.Invoices.GroupBy(g => 1)
                //.Select(g => new {
                //    High = g.Count(i => i.Paid >= 1000),
                //    Low = g.Count(i => i.Paid < 1000),
                //    Sum = g.Sum(i => i.Paid)
                //});
                Utilities.PrintEnd(groupBy.ToString());
            }
        }
    }
}
