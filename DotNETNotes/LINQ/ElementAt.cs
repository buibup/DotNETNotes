using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class ElementAt : Base
    {
        public override string ToString()
        {
            return "ElementAt";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var elementAt = new ElementAt();
                Utilities.PrintStart(elementAt.ToString());
                var names = new[] { "Foo", "Bar", "Fizz", "Buzz" };
                var thirdName = names.ElementAt(2);
                Console.WriteLine(thirdName); //Fizz
                //The following throws ArgumentOutOfRangeException
                //var minusOnethName = names.ElementAt(-1);
                //var fifthName = names.ElementAt(4);
                Utilities.PrintEnd(elementAt.ToString());
            }
        }
    }
}
