using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_5
{
    class Program
    {

        static void Main()
        {
            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<int> longest = null;
            int maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int first = arr[i];
                List<int> print = new List<int>() { arr[i] };
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        print.Add(arr[j]);
                        i++;
                    }
                    else break;
                }
                if (print.Count > maxCount)
                {
                    longest = print;
                    maxCount = print.Count;
                }
                Console.WriteLine(string.Join(" ", print));
            }
            Console.WriteLine("Longest: " + string.Join(" ", longest));
        }
    }
}
