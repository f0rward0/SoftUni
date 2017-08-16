using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, List<string>>> performs = new Dictionary<string, SortedDictionary<string, List<string>>>();

        while(true)
        {
            string input = Console.ReadLine();
            if (input == "END")
                break;
            string[] arr = input.Split(';');
            if (performs.ContainsKey(arr[0]))
            {
                if (performs[arr[0]].ContainsKey(arr[1]))
                {
                    if(!(performs[arr[0]][arr[1]].Contains(arr[2])))
                        performs[arr[0]][arr[1]].Add(arr[2]);
                }
                else
                {
                    performs[arr[0]].Add(arr[1], new List<string> { arr[2] });
                }
            }
            else
            {
                performs.Add(arr[0], new SortedDictionary<string,List<string>>{{arr[1], new List<string>{arr[2]}}});
            }
        }

        foreach (var city in performs)
        {
            foreach (var place in city.Value)
            {
                place.Value.Sort();
            }
        }

        foreach (var item in performs)
        {
            Console.WriteLine(item.Key);
            foreach (var pair in item.Value)
            {
                Console.WriteLine("->{0}: {1}", pair.Key, string.Join(", ",pair.Value));
            }
        }
    }
}