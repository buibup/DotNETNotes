using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Empty : Base
    {
        public override string ToString()
        {
            return "Empty";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var empty = new Empty();
                Utilities.PrintStart(empty.ToString());
                IEnumerable<int> emptyList = Enumerable.Empty<int>();
                var empDec = Enumerable.Empty<decimal>() == Enumerable.Empty<decimal>(); // This is True
                var empInt = Enumerable.Empty<int>() == Enumerable.Empty<decimal>(); // This is False
                Console.WriteLine($"empDec:{empDec}, empInt:{empInt}");
                Utilities.PrintEnd(empty.ToString());
            }
        }
    }
}
