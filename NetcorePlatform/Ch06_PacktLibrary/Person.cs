using System;
using System.Collections.Generic;
using static System.Console;


namespace Packt.CS7
{
    public class Person : IComparable<Person>
    {
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth}");
        }

        public Person Procreate(Person partner)
        {
            var baby = new Person
            {
                Name = $"Baby of {this.Name} and {partner.Name}",
                DateOfBirth = DateTime.Now
            };

            this.Children.Add(baby);
            partner.Children.Add(baby);
            return baby;
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
