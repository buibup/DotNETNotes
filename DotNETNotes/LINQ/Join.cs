using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class Join : Base
    {
        public override string ToString()
        {
            return "Join";
        }
        public override void Output(bool isShow)
        {
            if (isShow)
            {
                var join = new Join();
                Utilities.PrintStart(join.ToString());
                var developers = new[] {
                new Developer {
                Id = 1,
                Name = "Foobuzz"
                },
                new Developer {
                Id = 2,
                Name = "Barfizz"
                }
                };
                var projects = new[] {new Project {
                DeveloperId = 1,
                Name = "Hello World 3D"
                },
                new Project {
                DeveloperId = 1,
                Name = "Super Fizzbuzz Maker"
                },
                new Project {
                DeveloperId = 2,
                Name = "Citizen Kane - The action game"
                },
                new Project {
                DeveloperId = 2,
                Name = "Pro Pong 2016"
                }
                };
                var denormalized = developers.Join(
                inner: projects,
                outerKeySelector: dev => dev.Id,
                innerKeySelector: proj => proj.DeveloperId,
                resultSelector:
                (dev, proj) => new {
                    ProjectName = proj.Name,
                    DeveloperName = dev.Name
                });
                foreach (var item in denormalized)
                {
                    Console.WriteLine("{0} by {1}", item.ProjectName, item.DeveloperName);
                }
                //Hello World 3D by Foobuzz
                //Super Fizzbuzz Maker by Foobuzz
                //Citizen Kane - The action game by Barfizz
                //Pro Pong 2016 by Barfizz
                Utilities.PrintEnd(join.ToString());
            }
        }
    }
}
