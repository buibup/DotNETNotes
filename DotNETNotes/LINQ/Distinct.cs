using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Distinct : Base
    {
        public override string ToString()
        {
            return "Distinct";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var distinct = new Distinct();
                Utilities.PrintStart(distinct.ToString());
                var numbers = new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
                var distinctNumbers = numbers.Distinct();
                Console.WriteLine(string.Join(",", distinctNumbers));
                Utilities.PrintEnd(distinct.ToString());
            }
        }
    }
}
