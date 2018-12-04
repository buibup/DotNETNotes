using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Sum : Base
    {
        public override string ToString()
        {
            return "Sum";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var sum = new Sum();
                Utilities.PrintStart(sum.ToString());
                var numbers = new[] { 1, 2, 3, 4 };
                var sumOfAllNumbers = numbers.Sum();
                Console.WriteLine(sumOfAllNumbers); //10
                var cities = new[] {
                    new {Population = 1000},
                    new {Population = 2500},
                    new {Population = 4000}
                };
                var totalPopulation = cities.Sum(c => c.Population);
                Console.WriteLine(totalPopulation);
                Utilities.PrintEnd(sum.ToString());
            }
        }
    }
}
