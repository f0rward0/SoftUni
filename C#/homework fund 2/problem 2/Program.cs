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
            int n, m;
            int[] arr=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            n = arr[0];
            m = arr[1];
            int[,] matrix = new int[n, m];
            int rowsLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);
            int[,] sumMatrix = new int[3, 3];

            for(int i=0;i<n;i++)
            {
                arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int j=0;j<m;j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row , col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]+
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        sumMatrix[0, 0] = matrix[row, col];
                        sumMatrix[0, 1] = matrix[row, col+1];
                        sumMatrix[0, 2] = matrix[row, col+2];
                        sumMatrix[1, 0] = matrix[row+1, col];
                        sumMatrix[1, 1] = matrix[row+1, col+1];
                        sumMatrix[1, 2] = matrix[row+1, col+2];
                        sumMatrix[2, 0] = matrix[row+2, col];
                        sumMatrix[2, 1] = matrix[row+2, col+1];
                        sumMatrix[2, 2] = matrix[row+2, col+2];

                    }
                }


            Console.Clear();

            for (int row = 0; row < sumMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < sumMatrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", sumMatrix[row, col]);
                }

                Console.WriteLine();
            }


        }
    }
}
