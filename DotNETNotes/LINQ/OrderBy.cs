using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class OrderBy : Base
    {
        public override string ToString()
        {
            return "OrderBy";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var orderBy = new OrderBy();
                Utilities.PrintStart(orderBy.ToString());
                var persons = new[]
                {
                new {Id = 1, Name = "Foo"},
                new {Id = 2, Name = "Bar"},
                new {Id = 3, Name = "Fizz"},
                new {Id = 4, Name = "Buzz"}
                };
                var personsSortedByName = persons.OrderBy(p => p.Name);
                Console.WriteLine(string.Join(",", personsSortedByName.Select(p => p.Id).ToArray()));
                Utilities.PrintEnd(orderBy.ToString());
            }
        }
    }
}
