using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Last : Base
    {
        public override string ToString()
        {
            return "Last";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var last = new Last();
                Utilities.PrintStart(last.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var lastNumber = numbers.Last();
                Console.WriteLine(lastNumber); //5
                var lastEvenNumber = numbers.Last(n => (n & 1) == 0);
                Console.WriteLine(lastEvenNumber); //4


                //The following throws InvalidOperationException:
                //var lastNegativeNumber = numbers.Last(n => n < 0);
                Utilities.PrintEnd(last.ToString());
            }
        }
    }
}
