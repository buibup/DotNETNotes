using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Min : Base
    {
        public override string ToString()
        {
            return "Min";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var min = new Min();
                Utilities.PrintStart(min.ToString());
                var numbers = new[] { 1, 2, 3, 4 };
                var minNumber = numbers.Min();
                Console.WriteLine(minNumber); //1
                var cities = new[] {
                new {Population = 1000},
                new {Population = 2500},
                new {Population = 4000}
                };
                var minPopulation = cities.Min(c => c.Population);
                Console.WriteLine(minPopulation); //1000
                Utilities.PrintEnd(min.ToString());
            }
        }
    }
}
