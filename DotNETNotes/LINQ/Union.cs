using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Union : Base
    {
        public override string ToString()
        {
            return "Union";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var union = new Union();
                Utilities.PrintStart(union.ToString());
                var numbers1to5 = new[] { 1, 2, 3, 4, 4, 5 };
                var numbers4to8 = new[] { 4, 5, 6, 7, 8, 8 };
                var numbers1to8 = numbers1to5.Union(numbers4to8);
                Console.WriteLine(string.Join(",", numbers1to8));
                //1,2,3,4,5,6,7,8
                Utilities.PrintEnd(union.ToString());
            }
        }
    }
}
