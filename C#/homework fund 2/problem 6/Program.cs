using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_6
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<char, int> letters = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (letters.ContainsKey(input[i]))
                {
                    letters[input[i]]++;
                }
                else
                {
                    letters[input[i]] = 1;
                }
            }
            foreach (var letter in letters)
            {
                Console.WriteLine("{0}: {1} time/s", letter.Key, letter.Value);
            }
        }
    }
}