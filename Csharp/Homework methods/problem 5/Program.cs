using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_5
{
    class Program
    {
        static double GetReversedNumber(double input)
        {
            double output;
            string text = input.ToString();

            char[] cArray = text.ToCharArray();
            string  reverse= String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            output = double.Parse(reverse);
            return output;
            
        }
        static void Main(string[] args)
        {
            double reversed = GetReversedNumber(123.45);
            double reversed1 = GetReversedNumber(256);
            double reversed2 = GetReversedNumber(0.12);
            Console.WriteLine(reversed);
            Console.WriteLine(reversed1);
            Console.WriteLine(reversed2);
        }
    }
}
