using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Contains : Base
    {
        public override string ToString()
        {
            return "Contains";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var contains = new Contains();
                Utilities.PrintStart(contains.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5 };
                Console.WriteLine(numbers.Contains(3)); //True
                Console.WriteLine(numbers.Contains(34)); //False
                Utilities.PrintEnd(contains.ToString());
            }
        }
    }
}
