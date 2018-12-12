using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class ToDictionary : Base
    {
        public override string ToString()
        {
            return "ToDictionary";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var toDictionary = new ToDictionary();
                Utilities.PrintStart(toDictionary.ToString());
                var persons = new[] {
                new { Name="Fizz", Id=1},
                new { Name="Buzz", Id=2},
                new { Name="Foo", Id=3},
                new { Name="Bar", Id=4},
                };

                var personsById = persons.ToDictionary(p => p.Id);
                // personsById is a Dictionary<int,object>
                Console.WriteLine(personsById[1].Name); //Fizz
                Console.WriteLine(personsById[2].Name); //Buzz

                var namesById = persons.ToDictionary(p => p.Id, p => p.Name);
                //namesById is a Dictionary<int,string>
                Console.WriteLine(namesById[3]); //Foo
                Console.WriteLine(namesById[4]); //Bar

                var persons2 = new[] {
                new { Name="Fizz", Id=1},
                new { Name="Buzz", Id=2},
                new { Name="Foo", Id=3},
                new { Name="Bar", Id=4},
                new { Name="Oops", Id=4}
                };
                //var willThrowException = persons2.ToDictionary(p => p.Id);
                Utilities.PrintEnd(toDictionary.ToString());
            }
        }
    }
}
