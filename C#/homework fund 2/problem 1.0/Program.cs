using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_fund_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int num;
            int[,] matrix = new int[N, N];
            
            for(int i=0;i<N;i++)
            {
                num = i+1;
                for(int j=0;j<N;j++)
                {
                    matrix[i, j] = num;
                    Console.Write("{0} ", matrix[i, j]);
                    num = num + N;
                }
                Console.WriteLine();
            }
            
        }
    }
}

