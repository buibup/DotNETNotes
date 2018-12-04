using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class ToLookup : Base
    {
        public override string ToString()
        {
            return "ToLookup";
        }

        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var toLookup = new ToLookup();
                Utilities.PrintStart(toLookup.ToString());
                var persons = new[] {
                new { Name="Fizz", Job="Developer"},
                new { Name="Buzz", Job="Developer"},
                new { Name="Foo", Job="Astronaut"},
                new { Name="Bar", Job="Astronaut"},
                };
                var groupedByJob = persons.ToLookup(p => p.Job);
                foreach (var theGroup in groupedByJob)
                {
                    Console.WriteLine(
                    "{0} are {1}s",
                    string.Join(",", theGroup.Select(g => g.Name).ToArray()),
                    theGroup.Key);
                }
                Utilities.PrintEnd(toLookup.ToString());
            }
        }
    }
}
