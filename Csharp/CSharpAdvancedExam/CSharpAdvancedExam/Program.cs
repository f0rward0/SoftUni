using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpAdvancedExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            /*var checkInput = input;
            string[] startArr = input.Split( '@').ToArray();
            string singer = startArr[0];
            string stuff = startArr[1];
            string venueStr = Regex.Replace(stuff, @"[^A-z ]+", "");
            string venue = venueStr.Trim();
            string earnings = Regex.Replace(checkInput, @"[a-zA-z@]+", "");
            long[] earningsArr = earnings.Trim().Split().Select(long.Parse).ToArray();
            long amount = earningsArr[0] * earningsArr[1];*/
            string venue = null;
            
            var holder=new Dictionary<string,Dictionary<string,long>>();

            while (input!="End")
            {
                var checkInput = input;
                string[] startArr = input.Split('@').ToArray();
                string singer = startArr[0];
                string stuff = startArr[1];
                string venueStr = Regex.Replace(stuff, @"[^A-z ]+", "");
                venue = venueStr.Trim();
                string earnings = Regex.Replace(checkInput, @"[a-zA-z@]+", "");
                long[] earningsArr = earnings.Trim().Split().Select(long.Parse).ToArray();
                long amount = earningsArr[0] * earningsArr[1];


                if(!holder.ContainsKey(venue))
                {
                    holder.Add(venue, new Dictionary<string, long>() { { singer, amount } });
                }
                else
                {
                    if(holder[venue].ContainsKey(singer))
                    {
                        holder[venue][singer]+=amount;
                    }
                    else
                    {
                        holder[venue].Add(singer,amount);
                    }
                }




                
                
                input = Console.ReadLine();
            }

            




            foreach (var pis in holder)
            {
                Console.WriteLine("{0}",pis.Key);
                
                foreach(var sing in pis.Value.OrderByDescending(p=>p.Value))
                {
                    Console.WriteLine("#  {0}-> {1}",sing.Key,sing.Value);
                    
                }
            }

        }
    }
}
