using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Max : Base
    {
        public override string ToString()
        {
            return "Max";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var max = new Max();
                Utilities.PrintStart(max.ToString());
                var numbers = new[] { 1, 2, 3, 4 };
                var maxNumber = numbers.Max();
                Console.WriteLine(maxNumber); //4
                var cities = new[] {
                new {Population = 1000},
                new {Population = 2500},
                new {Population = 4000}
                };
                var maxPopulation = cities.Max(c => c.Population);
                Console.WriteLine(maxPopulation); //4000
                Utilities.PrintEnd(max.ToString());
            }
        }
    }
}
