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
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            arr[i] = pi;
        }
    //    int D=2000000;


    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        for (int j = 0; j < arr.Length; j++)
    //        {
    //            if (Math.Abs(arr[i] - arr[j]) < D && Math.Abs(arr[i] - arr[j])!=0)
    //            {
    //                D =Math.Abs(arr[i] - arr[j]);
    //            }
    //        }
    //    }



        Console.WriteLine(MinDistance(arr));






    }
    public static int MinDistance(int [] ar){
        int [] a = ar;
        int aSize = ar.Length;
        int dMin = Math.Abs(a[0] - a[1]);//MaxInt
        for(int i=0; i< aSize; i++)
        {
            for(int j=i+1; j< aSize;j++)
            {
                if (Math.Abs(a[i] - a[j])!=0)
                    dMin = Math.Min(dMin, Math.Abs( a[i]-a[j]));
            }
        }
        return dMin;
    }

}