using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Intersect : Base
    {
        public override string ToString()
        {
            return "Intersect";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var intersect = new Intersect();
                Utilities.PrintStart(intersect.ToString());
                var numbers1to10 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var numbers5to15 = new[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                var numbers5to10 = numbers1to10.Intersect(numbers5to15);
                Console.WriteLine(string.Join(",", numbers5to10));
                Utilities.PrintEnd(intersect.ToString());
            }
        }
    }
}
