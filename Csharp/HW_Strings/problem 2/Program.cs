using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    class String_Lenght
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            Console.Write(input);
            for(int i=input.Length;i<20;i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
