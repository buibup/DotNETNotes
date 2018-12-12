using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Reverse : Base
    {
        public override string ToString()
        {
            return "Reverse";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var reverse = new Reverse();
                Utilities.PrintStart(reverse.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var reversed = numbers.Reverse();
                Console.WriteLine(string.Join(",", reversed.ToArray()));
                Utilities.PrintEnd(reverse.ToString());
            }
        }
    }
}
