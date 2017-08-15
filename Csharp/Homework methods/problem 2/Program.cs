using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    class Program
    {
        static string GetLastDigitAsWord(int number)
        {
            while(number>=10)
            {
                number %= 10;
            }
            if (number == 1 )
                return "one";
            else if (number == 2 )
                return "two";
            else if (number == 3)
                return "three";
            else if (number == 4)
                return "four";
            else if (number == 5)
                return "five";
            else if (number == 6)
                return "six";
            else if (number == 7)
                return "seven";
            else if (number == 8)
                return "eight";
            else if (number == 9)
                return "nine";
            else return "zero";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastDigitAsWord(512));
            Console.WriteLine(GetLastDigitAsWord(1024));
            Console.WriteLine(GetLastDigitAsWord(12309));
        }
    }
}
