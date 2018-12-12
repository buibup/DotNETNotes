using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class OfType : Base
    {
        public override string ToString()
        {
            return "OfType";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var ofType = new OfType();
                Utilities.PrintStart(ofType.ToString());
                var mixed = new object[] { 1, "Foo", 2, "Bar", 3, "Fizz", 4, "Buzz" };
                var numbers = mixed.OfType<int>();
                Console.WriteLine(string.Join(",", numbers.ToArray()));
                Utilities.PrintEnd(ofType.ToString());
            }
        }
    }
}
