using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class OrderByDescending : Base
    {
        public override string ToString()
        {
            return "OrderByDescending";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var orderByDescending = new OrderByDescending();
                Utilities.PrintStart(orderByDescending.ToString());
                var persons = new[]
                {
                new {Id = 1, Name = "Foo"},
                new {Id = 2, Name = "Bar"},
                new {Id = 3, Name = "Fizz"},
                new {Id = 4, Name = "Buzz"}
                };
                var personsSortedByNameDescending = persons.OrderByDescending(p => p.Name);
                Console.WriteLine(string.Join(",", personsSortedByNameDescending.Select(p => p.Id).ToArray()));
                Utilities.PrintEnd(orderByDescending.ToString());
            }
        }
    }
}
