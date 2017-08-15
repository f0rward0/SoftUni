using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbers
{
    static void Main()
    {
        int[] arrNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(arrNums);

        Console.WriteLine(string.Join(" ",arrNums));
    }
}