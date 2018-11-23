using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Any : Base
    {
        public override string ToString()
        {
            return "Any";
        }

        public override void Output(bool isShow)
        {
            if (isShow)
            {
                Utilities.PrintStart(new Any().ToString());
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var isNotEmpty = numbers.Any();
                Console.WriteLine(isNotEmpty); //True
                var anyNumberIsOne = numbers.Any(n => n == 1);
                Console.WriteLine(anyNumberIsOne); //True
                var anyNumberIsSix = numbers.Any(n => n == 6);
                Console.WriteLine(anyNumberIsSix); //False
                var anyNumberIsOdd = numbers.Any(n => (n & 1) == 1);
                Console.WriteLine(anyNumberIsOdd); //True
                var anyNumberIsNegative = numbers.Any(n => n < 0);
                Console.WriteLine(anyNumberIsNegative); //False
                Utilities.PrintEnd(new Any().ToString());
            }
        }
    }
}
