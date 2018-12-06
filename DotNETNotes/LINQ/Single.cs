using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Single : Base
    {
        public override string ToString()
        {
            return "Single";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var single = new Single();
                Utilities.PrintStart(single.ToString());
                var oneNumber = new[] { 5 };
                var theOnlyNumber = oneNumber.Single();
                Console.WriteLine(theOnlyNumber); //5
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var theOnlyNumberSmallerThanTwo = numbers.Single(n => n < 2);
                Console.WriteLine(theOnlyNumberSmallerThanTwo); //1

                //The following throws InvalidOperationException since there is more than one element in the sequence:
                var theOnlyNumberInNumbers = numbers.Single();
                var theOnlyNegativeNumber = numbers.Single(n => n < 0);
                Utilities.PrintEnd(single.ToString());
            }
        }
    }
}
