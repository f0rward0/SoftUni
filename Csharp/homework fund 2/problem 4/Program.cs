using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dimentions: ");
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            string[,] matrix = new string[rows, cols];

            Console.WriteLine("Fill the matrix:");

            for (int i = 0; i < rows; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = temp[j];
                }
            }

            string element = null;
            int longestCount = 1;
            int currentCount = 1;

            //horizontal
            for (int i = 0; i < rows;i++ )
            {
                currentCount = 1;
                for(int j=0;j<cols-1;j++)
                {
                    if(matrix[i,j]==matrix[i,j+1])
                    {
                        currentCount++;
                        element = matrix[i, j];
                        if(currentCount>longestCount)
                        {
                            longestCount = currentCount;
                        }
                    }
                    else
                    {
                        currentCount = 1;
                    }

                }
            }
            
            //vertical
            for (int i = 0; i < cols;i++ )
            {
                currentCount = 1;
                for(int j=0;j<rows-1;j++)
                {
                    if(matrix[j,i]==matrix[j+1,i])
                    {
                        currentCount++;
                        element = matrix[j, i];
                        if (currentCount > longestCount)
                        {
                            longestCount = currentCount;
                        }
                    }
                    else
                    {
                        currentCount = 1;
                    }
                }
            }

            //diagonally
            int q = 0, p = 0;
            for (int i = 0; i < (rows - 1) * (cols - 1);i++ )
            {
                currentCount = 1;
                int n = q, m = p;
                while(true)
                {
                    if (n >= rows-1 || m >= cols-1)
                        break;
                    if(matrix[n,m]==matrix[n+1,m+1])
                    {
                        currentCount++;
                        element = matrix[n, m];
                        if (currentCount > longestCount)
                            longestCount = currentCount;
                       
                    }
                    m++;
                    n++;
                }
                if(i%cols+1==0)
                {
                    q++;
                }
                else
                {
                    p++;
                }
            }



            for (int i = 0; i < longestCount; i++)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}