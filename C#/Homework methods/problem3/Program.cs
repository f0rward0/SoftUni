using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{

    class Program
    {
        static string IsLargerThanNEighbours(int[] arr,int x)
        {
            if(x==0)
            {
                if(arr[0]>arr[1])
                {
                    return "True";
                }
                else 
                    return "False";
            }
            else if(x==arr.Length-1)
            {
                if (arr[arr.Length - 1] > arr[arr.Length - 2])
                    return "True";
                else
                    return "False";
            }
            else
            {
                if (arr[x] > arr[x + 1] && arr[x] > arr[x - 1])
                    return "True";
                else
                    return "False";
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            for(int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine(IsLargerThanNEighbours(numbers, i));
            }
        }
    }
}
