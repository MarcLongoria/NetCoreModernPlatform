using Packt.CS7;
using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int temp = x.Name.Length.CompareTo(y.Name.Length);
            if(temp == 0)
            {
                return x.Name.CompareTo(y.Name);

            }
            else
            {
                return temp;
            }
        }
    }
}
