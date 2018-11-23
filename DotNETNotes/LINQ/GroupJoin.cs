using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNETNotes.LINQ
{
    public class GroupJoin : Base
    {
        public override string ToString()
        {
            return "GroupJoin";
        }

        public override void Output(bool isShow)
        {
            if (isShow)
            {
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
                var projects = new[] {
                new Project {
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

                var grouped = developers.GroupJoin(
                inner: projects,
                outerKeySelector: dev => dev.Id,
                innerKeySelector: proj => proj.DeveloperId,
                resultSelector:
                (dev, projs) => new {
                    DeveloperName = dev.Name,
                    ProjectNames = projs.Select(p => p.Name).ToArray()
                });
                Utilities.PrintStart(new GroupJoin().ToString());
                foreach (var item in grouped)
                {
                    Console.WriteLine(
                    "{0}'s projects: {1}",
                    item.DeveloperName,
                    string.Join(", ", item.ProjectNames));
                }
                Utilities.PrintEnd(new GroupJoin().ToString());
            }
        }
    }

    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Project
    {
        public int DeveloperId { get; set; }
        public string Name { get; set; }
    }
}
