using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem__3
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
            List<float> dec=new List<float>();
            List<float> flt=new List<float>();
            for(int i=0;i<arr.Length;i++)
            {
                if (Math.Round(arr[i]) == arr[i])
                    dec.Add(arr[i]);
                else
                    flt.Add(arr[i]);
            }
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(" ", flt), flt.Min(), flt.Max(), flt.Sum(),Math.Round(flt.Average(),2));
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",string.Join(" ",dec),dec.Min(),dec.Max(),dec.Sum(),Math.Round(dec.Average(),2));
            
            





        }
    }
}
