using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            // the number of temperatures to analyse


            string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526

            int[] arr = temps.Split().Select(int.Parse).ToArray();
            Array.Sort(arr);
            int output = 5526;
            int noutput = -273;
            for (int i = 0; i < arr.Length; i++)
            {
                if (output > Math.Abs(arr[i]))
                {
                    output = Math.Abs(arr[i]);
                }
               
            }

            bool isNeg = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    isNeg = false;
                }
            }

            if (!isNeg)
            {
                Console.WriteLine(output);
            }
            else
                Console.WriteLine(0 - output);

           

            





        }
        catch (FormatException)
        {
            Console.WriteLine(0);
        }

    }
}