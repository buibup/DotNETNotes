using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class All : Base
    {
        public override string ToString()
        {
            return "All";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var all = new All();
                Utilities.PrintStart(all.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var allNumbersAreOdd = numbers.All(n => (n & 1) == 1);
                Console.WriteLine(allNumbersAreOdd); //False

                var allNumbersArePositive = numbers.All(n => n > 0);
                Console.WriteLine(allNumbersArePositive); //True

                var numbers1 = new int[0];
                var allNumbersArePositive1 = numbers1.All(n => n > 0);
                Console.WriteLine(allNumbersArePositive1); //True
                Utilities.PrintEnd(all.ToString());
            }
        }
    }
}
