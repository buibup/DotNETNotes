using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Where : Base
    {
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var personNames = new[]
                {
                    "Foo", "Bar", "Fizz", "Buzz"
                };
                var namesStartingWithF = personNames.Where(p => p.StartsWith("F"));
                Utilities.PrintStart(new Where().ToString());
                Console.WriteLine(string.Join(",", namesStartingWithF));
                Utilities.PrintEnd(new Where().ToString());
            }

        }

        public override string ToString()
        {
            return "Where";
        }
    }
}
