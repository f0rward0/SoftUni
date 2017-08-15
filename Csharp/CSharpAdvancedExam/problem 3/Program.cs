using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(?<=\bdouble\s)(\w+)");
            MatchCollection doubles = regex.Matches(input);
            Regex regexint = new Regex(@"(?<=\bint\s)(\w+)");
            MatchCollection ints = regexint.Matches(input);

            var integers=new List<string>();
            var doublers=new List<string>();

            while (input != "//END_OF_CODE")
            {

                doubles = regex.Matches(input);
                ints = regexint.Matches(input);

                foreach (Match p in doubles)
                {
                    doublers.Add(p.ToString());
                }
                foreach (Match q in ints)
                {
                    integers.Add(q.ToString());
                }
                input = Console.ReadLine();
            }
            doublers.Sort();
            integers.Sort();
            if (doublers.Count==0&&integers.Count==0)
            {
                Console.WriteLine("Doubles: None");
                Console.WriteLine("Ints: None");
            }
            else if(doublers.Count==0)
            {
                Console.WriteLine("Doubles: None");
                Console.WriteLine("Ints: " + string.Join(", ", integers));
            }
            else if(integers.Count==0)
            {
                Console.WriteLine("Ints: None");
                Console.WriteLine("Doubles: "+string.Join(", ",doublers));
            }
            else
            {
             Console.WriteLine("Doubles: "+string.Join(", ",doublers));
             Console.WriteLine("Ints: " + string.Join(", ", integers));
            }
        }
    }
}
