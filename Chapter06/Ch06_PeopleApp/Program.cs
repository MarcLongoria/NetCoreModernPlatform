using System;
using Packt.CS7;
using static System.Console;

namespace Ch06_PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var harry = new Person { Name = "Harry" };
            //var mary = new Person { Name = "Mary" };
            //var firstBaby = harry.Procreate(mary);
            //WriteLine($"{mary.Name} has {mary.Children.Count} children");
            //WriteLine($"{ harry.Name} has { harry.Children.Count}");
            //WriteLine($"{harry.Name}'s first child is named {harry.Children[0].Name}");


            //Interface code for IComparer and IComparable
            //Person[] people = {
            //    new Person { Name = "Simon"  },
            //    new Person { Name = "Jenny" },
            //    new Person { Name = "Adam"},
            //    new Person { Name = "Richard"} };

            //WriteLine("Initial list of people:");
            //foreach (var person in people)
            //{
            //    WriteLine($"{person.Name}");
            //}

            //WriteLine("Use Person's sort implementation.");
            //Array.Sort(people);
            //foreach (var person in people)
            //{
            //    WriteLine($"{person.Name}");
            //}

            //WriteLine("Use Person Comparer's sort implementation:");
            //Array.Sort(people, new PersonComparer());
            //foreach (var person in people)
            //{
            //    WriteLine($"{ person.Name}");
            //}
            //ReadLine();


            //Code for structs
            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X},{dv2.Y}) = {dv3.X},{dv3.Y}");
        }
    }
}