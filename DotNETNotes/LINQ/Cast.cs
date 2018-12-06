using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DotNETNotes.LINQ
{
    public class Cast : Base
    {
        public override string ToString()
        {
            return "Cast";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var cast = new Cast();
                Utilities.PrintStart(cast.ToString());
                var numbers = new List<int>() { 1, 2, 3, 4, 5 };
                Console.WriteLine(numbers.Cast<int>().First()); //1
                decimal[] numbersAsDecimal = numbers.Select(n => (decimal)n).ToArray();
                foreach(var item in numbersAsDecimal)
                {
                    Console.WriteLine(item);
                }
                Utilities.PrintStart(cast.ToString());
            }
        }
    }
}
