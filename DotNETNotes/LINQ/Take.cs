using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Take : Base
    {
        public override string ToString()
        {
            return "Take";
        }

        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var take = new Take();
                Utilities.PrintStart(take.ToString());
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var threeFirstNumbers = numbers.Take(3);
                Console.WriteLine(string.Join(",", threeFirstNumbers.ToArray()));
                Utilities.PrintEnd(take.ToString());
            }
        }
    }
}
