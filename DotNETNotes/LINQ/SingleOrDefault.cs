using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class SingleOrDefault : Base
    {
        public override string ToString()
        {
            return "SingleOrDefault";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var singleOrDefault = new SingleOrDefault();
                Utilities.PrintStart(singleOrDefault.ToString());
                var oneNumber = new[] { 5 };
                var theOnlyNumber = oneNumber.SingleOrDefault();
                Console.WriteLine(theOnlyNumber); //5
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var theOnlyNumberSmallerThanTwo = numbers.SingleOrDefault(n => n < 2);
                Console.WriteLine(theOnlyNumberSmallerThanTwo); //1
                var theOnlyNegativeNumber = numbers.SingleOrDefault(n => n < 0);
                Console.WriteLine(theOnlyNegativeNumber); //0
                //The following throws InvalidOperationException:
                //var theOnlyNumberInNumbers = numbers.SingleOrDefault();
                Utilities.PrintEnd(singleOrDefault.ToString());
            }
        }
    }
}
