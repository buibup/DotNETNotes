using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Average : Base
    {
        public override string ToString()
        {
            return "Average";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var average = new Average();
                Utilities.PrintStart(average.ToString());
                var numbers = new[] { 1, 2, 3, 4 };
                var averageNumber = numbers.Average();
                Console.WriteLine(averageNumber);
                // 2,5

                var cities = new[] {new {Population = 1000},
                new {Population = 2000},
                new {Population = 4000}
                };
                var averagePopulation = cities.Average(c => c.Population);
                Console.WriteLine(averagePopulation);
                // 2333,33
                Utilities.PrintEnd(average.ToString());
            }
        }
    }
}
