using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class FirstOrDefault : Base
    {
        public override string ToString()
        {
            return "FirstOrDefault";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var firstOrDefault = new FirstOrDefault();
                Utilities.PrintStart(firstOrDefault.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var firstNumber = numbers.FirstOrDefault();
                Console.WriteLine(firstNumber); //1
                var firstEvenNumber = numbers.FirstOrDefault(n => (n & 1) == 0);
                Console.WriteLine(firstEvenNumber); //2
                var firstNegativeNumber = numbers.FirstOrDefault(n => n < 0);
                Console.WriteLine(firstNegativeNumber); //0
                var words = new[] { "one", "two", "three", "four", "five" };
                var firstWord = words.FirstOrDefault();
                Console.WriteLine(firstWord); // one
                var firstLongWord = words.FirstOrDefault(w => w.Length > 3);
                Console.WriteLine(firstLongWord); // three
                var firstMissingWord = words.FirstOrDefault(w => w.Length > 5);
                Console.WriteLine(firstMissingWord); // null
                Utilities.PrintEnd(firstOrDefault.ToString());
            }
        }
    }
}
