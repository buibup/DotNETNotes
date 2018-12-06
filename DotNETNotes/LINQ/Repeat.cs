using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Repeat : Base
    {
        public override string ToString()
        {
            return "Repeat";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var repeat = new Repeat();
                Utilities.PrintStart(repeat.ToString());
                var repeats = Enumerable.Repeat("Hello", 4);
                foreach (var item in repeats)
                {
                    Console.WriteLine(item);
                }
                Utilities.PrintEnd(repeat.ToString());
            }
        }
    }
}
