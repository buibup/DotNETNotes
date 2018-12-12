using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class SkipWhile : Base
    {
        public override string ToString()
        {
            return "SkipWhile";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var skipWhile = new SkipWhile();
                Utilities.PrintStart(skipWhile.ToString());
                var numbers = new[] { 2, 4, 6, 8, 1, 3, 5, 7 };
                var oddNumbers = numbers.SkipWhile(n => (n & 1) == 0);
                Console.WriteLine(string.Join(",", oddNumbers.ToArray()));
                Utilities.PrintEnd(skipWhile.ToString());
            }
        }
    }
}
