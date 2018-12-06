using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Range : Base
    {
        public override string ToString()
        {
            return "Range";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var range = new Range();
                Utilities.PrintStart(range.ToString());
                Console.WriteLine(string.Join(",", Enumerable.Range(1, 10)));
                Console.WriteLine(string.Join(",", Enumerable.Range(10, 5)));
                Utilities.PrintEnd(range.ToString());
            }
        }
    }
}
