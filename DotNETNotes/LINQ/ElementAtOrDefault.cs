using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class ElementAtOrDefault : Base
    {
        public override string ToString()
        {
            return "ElementAtOrDefault";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var elementAtOrDefault = new ElementAtOrDefault();
                Utilities.PrintStart(elementAtOrDefault.ToString());
                var names = new[] { "Foo", "Bar", "Fizz", "Buzz" };
                var thirdName = names.ElementAtOrDefault(2);
                Console.WriteLine(thirdName); //Fizz
                var minusOnethName = names.ElementAtOrDefault(-1);
                Console.WriteLine(minusOnethName); //null
                var fifthName = names.ElementAtOrDefault(4);
                Console.WriteLine(fifthName); //null
                Utilities.PrintEnd(elementAtOrDefault.ToString());
            }
        }
    }
}
