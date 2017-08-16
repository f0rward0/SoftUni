using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToCharArray();
            int counter = 1;
            int i=0;
            while(i<arr.Length)
            {
                if (i == arr.Length - 1)
                {
                    if(arr.Length==1)
                    {
                        Console.Write("{0}{1}", counter, arr[i]);
                        break;
                    }
                    if (arr[i] == arr[i - 1])
                    {
                        counter++;
                        break;
                    }
                    else
                    {
                        Console.Write("{0}{1}", counter, arr[i]);
                        counter = 1;
                        break;
                    }
                }
                while(arr[i]==arr[i+1])
                {
                    counter++;
                    i++;
                    if (i == arr.Length - 1)
                        break;
                }
                Console.Write("{0}{1}", counter, arr[i]);
                counter = 1;
                i++;


            }
            Console.WriteLine();

        }
    }
}

