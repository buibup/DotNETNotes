using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Except : Base
    {
        public override string ToString()
        {
            return "Except";
        }

        public override void Output(bool isShow)
        {
            if (isShow)
            {
                Utilities.PrintStart(new Except().ToString());
                var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var evenNumbersBetweenSixAndFourteen = new[] { 6, 8, 10, 12 };
                var result = numbers.Except(evenNumbersBetweenSixAndFourteen);
                Console.WriteLine(string.Join(",", result));
                Utilities.PrintStart(new Except().ToString());
            }
        }
    }
}
