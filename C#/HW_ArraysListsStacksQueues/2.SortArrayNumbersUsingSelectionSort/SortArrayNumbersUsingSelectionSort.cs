using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayNumbersUsingSelectionSort
{
    static void Main()
    {
        int[] arrNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < arrNums.Length; i++)
        {
            int min = arrNums[i];

            for (int j = i; j < arrNums.Length; j++)
            {
                if (arrNums[j]<min)
                {
                    min = arrNums[j];
                }
            }

            arrNums[i] = min;
        }

        Console.WriteLine(string.Join(" ", arrNums));
    }
}