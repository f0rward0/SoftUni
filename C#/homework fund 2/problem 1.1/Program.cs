using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int rowsLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            int rows = 0;
            int cols = 0;

            string direction = "down";

            for(int i=1;i<n*n+1;i++)
            {
                if(direction=="down"&&rows>n-1)
                {
                    direction = "up";
                    rows--;
                    cols++;
                }
                else if(direction=="up"&&rows<0)
                {
                    direction = "down";
                    rows++;
                    cols++;

                }
                matrix[rows, cols] = i;
                if(i%n==0)
                {
                    Console.WriteLine();
                }
                if(direction=="down")
                {
                    rows++;
                }
                else if(direction=="up")
                {
                    rows--;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }

        }
    }
}
