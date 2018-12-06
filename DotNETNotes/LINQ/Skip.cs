using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Skip : Base
    {
        public override string ToString()
        {
            return "Skip";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var skip = new Skip();
                Utilities.PrintStart(skip.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var allNumbersExceptFirstTwo = numbers.Skip(2);
                Console.WriteLine(string.Join(",", allNumbersExceptFirstTwo.ToArray()));
                Utilities.PrintEnd(skip.ToString());
            }
        }
    }
}
