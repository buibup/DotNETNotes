using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class LeftOuterJoin : Base
    {
        public override string ToString()
        {
            return "LeftOuterJoin";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var leftOuterJoin = new LeftOuterJoin();
                Utilities.PrintStart(leftOuterJoin.ToString());
                var magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
                var terry = new Person { FirstName = "Terry", LastName = "Adams" };
                var barley = new Pet { Name = "Barley", Owner = terry };
                var people = new[] { magnus, terry };
                var pets = new[] { barley };
                var query =
                from person in people
                join pet in pets on person equals pet.Owner into gj
                from subpet in gj.DefaultIfEmpty()
                select new
                {
                    person.FirstName,
                    PetName = subpet?.Name ?? "-" // Use - if he has no pet
                };
                foreach (var p in query)
                    Console.WriteLine($"{p.FirstName}: {p.PetName}");
                Utilities.PrintEnd(leftOuterJoin.ToString());
            }
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Pet
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
    }
}
