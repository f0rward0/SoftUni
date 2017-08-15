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
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            long x = long.Parse(Console.ReadLine());
            a[i] = 0;
            while (x != 0)
            {
                x = x / 2;
                a[i]++;
            }

        }

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }

    }
    

}