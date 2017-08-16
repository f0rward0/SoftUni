using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem__4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            Console.Write(arr[0]);

            for(int i=1;i<arr.Length;i++)
            {
                
                 
                if (arr[i] != arr[i - 1])
                    Console.Write("\n");
                else
                    Console.Write(" ");
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            

        }
    }
}
