using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequencesOfEqualStrings
{
    static void Main()
    {
        List<string> str = Console.ReadLine().Split(' ').ToList();
        Console.WriteLine();

        Console.Write(str[0] + " ");
        for (int i = 1; i < str.Count; i++)
        {
            if (!((str[i])==(str[i-1])))
            {
                Console.WriteLine();
            }
            Console.Write(str[i]+" ");
        }

        Console.WriteLine();
    }
}