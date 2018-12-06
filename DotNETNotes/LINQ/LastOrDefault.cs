using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class LastOrDefault : Base
    {
        public override string ToString()
        {
            return "LastOrDefault";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var lastOrDefault = new LastOrDefault();
                Utilities.PrintStart(lastOrDefault.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var lastNumber = numbers.LastOrDefault();
                Console.WriteLine(lastNumber); //5
                var lastEvenNumber = numbers.LastOrDefault(n => (n & 1) == 0);
                Console.WriteLine(lastEvenNumber); //4
                var lastNegativeNumber = numbers.LastOrDefault(n => n < 0);
                Console.WriteLine(lastNegativeNumber); //0
                var words = new[] { "one", "two", "three", "four", "five" };
                var lastWord = words.LastOrDefault();
                Console.WriteLine(lastWord); // five
                var lastLongWord = words.LastOrDefault(w => w.Length > 4);
                Console.WriteLine(lastLongWord); // three
                var lastMissingWord = words.LastOrDefault(w => w.Length > 5);
                Console.WriteLine(lastMissingWord); // null
                Utilities.PrintEnd(lastOrDefault.ToString());
            }
        }
    }
}
