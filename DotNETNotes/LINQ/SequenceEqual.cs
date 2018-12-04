using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class SequenceEqual : Base
    {
        public override string ToString()
        {
            return "SequenceEqual";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var sequenceEqual = new SequenceEqual();
                Utilities.PrintStart(sequenceEqual.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var sameNumbers = new[] { 1, 2, 3, 4, 5 };
                var sameNumbersInDifferentOrder = new[] { 5, 1, 4, 2, 3 };
                var equalIfSameOrder = numbers.SequenceEqual(sameNumbers);
                Console.WriteLine(equalIfSameOrder); //True
                var equalIfDifferentOrder = numbers.SequenceEqual(sameNumbersInDifferentOrder);
                Console.WriteLine(equalIfDifferentOrder); //False
                Utilities.PrintEnd(sequenceEqual.ToString());
            }
        }
    }
}
