using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Zip : Base
    {
        public override string ToString()
        {
            return "Zip";
        }

        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var zip = new Zip();
                Utilities.PrintStart(zip.ToString());

                var tens = new[] { 10, 20, 30, 40, 50 };
                var units = new[] { 1, 2, 3, 4, 5 };
                var sums = tens.Zip(units, (first, second) => first + second);
                Console.WriteLine(string.Join(",", sums));

                Utilities.PrintEnd(zip.ToString());
            }
        }
    }
}
