using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class DefaultIfEmpty : Base
    {
        public override string ToString()
        {
            return "DefaultIfEmpty";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var defaultIfEmpty = new DefaultIfEmpty();
                Utilities.PrintStart(defaultIfEmpty.ToString());
                var numbers = new[] { 2, 4, 6, 8, 1, 3, 5, 7 };
                var numbersOrDefault = numbers.DefaultIfEmpty();
                Console.WriteLine(numbers.SequenceEqual(numbersOrDefault)); //True
                var noNumbers = new int[0];
                var noNumbersOrDefault = noNumbers.DefaultIfEmpty();
                Console.WriteLine(noNumbersOrDefault.Count()); //1
                Console.WriteLine(noNumbersOrDefault.Single()); //0
                var noNumbersOrExplicitDefault = noNumbers.DefaultIfEmpty(34);
                Console.WriteLine(noNumbersOrExplicitDefault.Count()); //1
                Console.WriteLine(noNumbersOrExplicitDefault.Single()); //34
                Utilities.PrintEnd(defaultIfEmpty.ToString());
            }
        }
    }
}
