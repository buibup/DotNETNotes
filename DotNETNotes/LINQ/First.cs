using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class First : Base
    {
        public override string ToString()
        {
            return "First";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var first = new First();
                Utilities.PrintStart(first.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var firstNumber = numbers.First();
                Console.WriteLine(firstNumber); //1
                var firstEvenNumber = numbers.First(n => (n & 1) == 0);
                Console.WriteLine(firstEvenNumber); //2
                var firstNegativeNumber = numbers.FirstOrDefault(n => n < 0);
                Console.WriteLine(firstNegativeNumber);
                Utilities.PrintEnd(first.ToString());
            }
        }
    }
}
