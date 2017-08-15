using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW_Regex
{
    class seriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Za-z])(\1+)";

            Regex regex = new Regex(pattern);
            string result = regex.Replace(input, @"$1");

            Console.Clear();
            Console.WriteLine(result);


        }
    }
}
