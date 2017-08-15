using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace problem_3
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<![._-])\b[a-zA-Z0-9]+(?:[._-]?[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:-[a-zA-Z0-9]+)*(?:\.[a-zA-Z0-9]+)+\b";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Console.Clear();
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
