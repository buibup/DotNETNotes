using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class TakeWhile : Base
    {
        public override string ToString()
        {
            return "TakeWhile";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var takeWhile = new TakeWhile();
                Utilities.PrintStart(takeWhile.ToString());
                var numbers = new[] { 2, 4, 6, 10, 1, 3, 5, 7, 8 };
                var evenNumbers = numbers.TakeWhile(n => (n & 1) == 0);
                Console.WriteLine(string.Join(",", evenNumbers.ToArray()));
                Utilities.PrintEnd(takeWhile.ToString());
            }
        }
    }
}
