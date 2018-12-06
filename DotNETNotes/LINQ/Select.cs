using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Select : Base
    {
        public override string ToString()
        {
            return "Select";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var select = new Select();
                Utilities.PrintStart(select.ToString());
                var persons = new[]
                {
                new {Id = 1, Name = "Foo"},
                new {Id = 2, Name = "Bar"},
                new {Id = 3, Name = "Fizz"},
                new {Id = 4, Name = "Buzz"}
                };
                var names = persons.Select(p => p.Name);
                Console.WriteLine(string.Join(",", names.ToArray()));
                Utilities.PrintEnd(select.ToString());
            }
        }
    }
}
