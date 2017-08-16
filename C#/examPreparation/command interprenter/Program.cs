using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace command_interprenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var input = Console.ReadLine();
            string pattern = @"(/d)";
            var rgx = new Regex(pattern);

            MatchCollection matches = rgx.Matches(input);
            

           

            while(input!="end")
            {
                foreach(Match match in matches)
                {
                    var begin = int.Parse(match.Groups[1].Value);
                    var count = int.Parse(match.Groups[2].Value);

                    
                    
                    List<long> reverseL = new List<long>();
                    for(int j=begin;j<begin+count;j++)
                    {
                        reverseL.Add(arr[j]);
                    }
                    reverseL.Reverse();
                    int k = 0;
                    for (int i = begin; i < begin + count; i++)
                    {
                        
                        arr[i]=reverseL[k];
                        k++;
                    }


                    
                }
                


                input=Console.ReadLine();
            }
            Console.Write("[");
            for(int i=0;i<arr.Length-1;i++)
                Console.Write("{0}, ",arr[i]);
            Console.Write("{0}", arr.Last());
            Console.WriteLine("]");

        }
    }
}
