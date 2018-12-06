using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class ThenBy : Base
    {
        public override string ToString()
        {
            return "ThenBy";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var thenBy = new ThenBy();
                Utilities.PrintStart(thenBy.ToString());
                var persons = new[]
                {
                new {Id = 1, Name = "Foo", Order = 1},
                new {Id = 1, Name = "FooTwo", Order = 2},
                new {Id = 2, Name = "Bar", Order = 2},
                new {Id = 2, Name = "BarTwo", Order = 1},
                new {Id = 3, Name = "Fizz", Order = 2},
                new {Id = 3, Name = "FizzTwo", Order = 1},
                };
                var personsSortedByName = persons.OrderBy(p => p.Id).ThenBy(p => p.Order);
                Console.WriteLine(string.Join(",", personsSortedByName.Select(p => p.Name)));
                Utilities.PrintEnd(thenBy.ToString());
            }
        }
    }
}
