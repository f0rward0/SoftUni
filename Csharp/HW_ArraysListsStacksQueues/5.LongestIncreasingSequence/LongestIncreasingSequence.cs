using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestIncreasingSequence
{
    static void Main()
    {
        List<int> listInt = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Console.WriteLine();

        int maxLength = 1;
        int presentLength = 1;
        int lastIndex = 0;

        Console.Write(listInt[0] + " ");

        for (int i = 1; i < listInt.Count; i++)
        {
            if (listInt[i]>listInt[i-1])
            {
                Console.Write(listInt[i] + " ");
                presentLength++;

            }
            else
            {
                if (presentLength>maxLength)
                {
                    maxLength = presentLength;
                    lastIndex = i - 1;
                }
                presentLength = 1;

                Console.WriteLine();
                Console.Write(listInt[i] + " ");              
            }
        }

        if (presentLength>maxLength)
        {
            maxLength = presentLength;
            lastIndex = listInt.Count - 1;
        }

        Console.WriteLine();
        Console.Write("Longest: ");
        for (int i = lastIndex-maxLength+1; i <= lastIndex; i++)
        {
            Console.Write(listInt[i] + " ");
        }

        Console.WriteLine();
    }
}