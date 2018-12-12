using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class ToList : Base
    {
        public override string ToString()
        {
            return "ToList";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var toList = new ToList();
                Utilities.PrintStart(toList.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var someNumbers = numbers.Where(n => n < 6);
                Console.WriteLine(someNumbers.GetType().Name);
                //WhereArrayIterator`1
                var someNumbersList = someNumbers.ToList();
                Console.WriteLine(
                someNumbersList.GetType().Name + " - " +
                someNumbersList.GetType().GetGenericArguments()[0].Name);
                //List`1 - Int32
                Utilities.PrintEnd(toList.ToString());
            }
        }
    }
}
