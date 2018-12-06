using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Count : Base
    {
        public override string ToString()
        {
            return "Count";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var count = new Count();
                Utilities.PrintStart(count.ToString());
                IEnumerable<int> numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var numbersCount = numbers.Count();
                Console.WriteLine(numbersCount); //10
                var evenNumbersCount = numbers.Count(n => (n & 1) == 0);
                Console.WriteLine(evenNumbersCount); //5
                Utilities.PrintEnd(count.ToString());
            }
        }
    }
}
