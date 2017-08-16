using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Persons
{
    class PersonMain
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Johny Kitaeca", 25);
            Person p2= new Person("Beihui Ahmed", 34, "Q.Angelov@abv.bg");

            Console.WriteLine(p1);
            Console.WriteLine(p2);

          
        }
    }
}