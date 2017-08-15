using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_7
{
class Program
{
    static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            List<string> names=new List<string>();
            string input = Console.ReadLine();
            do
            {
                names = input.Split('-').ToList();
                phonebook[names[0]] = names[1];
                names.Clear();
                input = Console.ReadLine();

            } while (input != "search");

            while(input!="END")
            {
                input = Console.ReadLine();
                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine("{0} -> {1}", input, phonebook[input]);
                }
                else
                    Console.WriteLine("Contact {0} does not exists", input);
            }
            

        }
    }
}
