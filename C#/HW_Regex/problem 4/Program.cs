using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace problem_4
{
    class SentenceExtractor
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = @"[A-Z][\w\s-,]* " + keyword + @" [\w\s-,]*[.!?]";

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
