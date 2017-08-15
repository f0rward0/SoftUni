using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CategorizeNumbersAndFindMinMaxAverage
{
    static void Main()
    {
        List<double> doubleNums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        Console.WriteLine();

        List<double> firstList = new List<double>();
        List<double> secondList = new List<double>();

        for (int i = 0; i < doubleNums.Count; i++)
        {
            if (doubleNums[i] % 1 == 0)
            {
                secondList.Add(doubleNums[i]);
            }
            else
            {
                firstList.Add(doubleNums[i]);
            }
        }

        for (int i = 0; i < firstList.Count; i++)
        {
            if (i < (firstList.Count-1))
            {
                Console.Write(firstList[i] + ", ");
            }
            else
            {
                Console.Write(firstList[i] + " -> ");
            } 
        }
        Console.Write("min: {0}, max: {1}, sum: {2}, avg: {3:F2}", firstList.Min(), firstList.Max(), firstList.Sum(), firstList.Average());

        Console.WriteLine();
        for (int i = 0; i < secondList.Count; i++)
        {
            if (i < (secondList.Count - 1))
            {
                Console.Write(secondList[i] + ", ");
            }
            else
            {
                Console.Write(secondList[i] + " -> ");
            }
        }
        Console.Write("min: {0}, max: {1}, sum: {2}, avg: {3:F2}", secondList.Min(), secondList.Max(), secondList.Sum(), secondList.Average());

        Console.WriteLine();
       // Console.WriteLine(string.Join(", "), firstList);
    }
}