using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_methods
{
    class Program
    {
        static int GetMax(int x,int y)
        {
            if(x>y)
            {
                return x;
            }
            else if(y>x)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(max);

        }
    }
}
