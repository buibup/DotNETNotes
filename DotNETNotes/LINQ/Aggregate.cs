using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Aggregate : Base
    {
        public override string ToString()
        {
            return "Aggregate";
        }

        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var _aggregate = new Aggregate();
                Utilities.PrintStart(_aggregate.ToString());
                //Generating a new object in each step:
                var elements = new[] { 1, 2, 3, 4, 5 };
                var commaSeparatedElements = elements.Aggregate(
                seed: "",
                func: (aggregate, element) => $"{aggregate}{element},");
                Console.WriteLine(commaSeparatedElements); 

                //Using the same object in all steps:
                var commaSeparatedElements2 = elements.Aggregate(
                    seed: new StringBuilder(),
                    func: (seed, element) => seed.Append($"{element},"));
                Console.WriteLine(commaSeparatedElements2.ToString()); 

                //Using a result selector:
                var commaSeparatedElements3 = elements.Aggregate(
                    seed: new StringBuilder(),
                    func: (seed, element) => seed.Append($"{element},"),
                    resultSelector: (seed) => seed.ToString());
                Console.WriteLine(commaSeparatedElements3); 

                //If a seed is omitted, the first element becomes the seed:
                var seedAndElements = elements.Select(n => n.ToString());
                var commaSeparatedElements4 = seedAndElements.Aggregate(
                func: (aggregate, element) => $"{aggregate}{element},");
                Console.WriteLine(commaSeparatedElements4);

                Utilities.PrintEnd(_aggregate.ToString());
            }
        }
    }
}
