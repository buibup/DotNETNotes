using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class ToArray : Base
    {
        public override string ToString()
        {
            return "ToArray";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var toArray = new ToArray();
                Utilities.PrintStart(toArray.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var someNumbers = numbers.Where(n => n < 6);
                Console.WriteLine(someNumbers.GetType().Name);
                //WhereArrayIterator`1
                var someNumbersArray = someNumbers.ToArray();
                Console.WriteLine(someNumbersArray.GetType().Name);
                //Int32[]
                Console.WriteLine(someNumbers.Count());
                Utilities.PrintEnd(toArray.ToString());
            }
        }
    }
}
