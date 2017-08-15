using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix=new string[rows,cols];
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }
            string[] commands = new string[5];
            while (commands.Length != 1 && commands[0] != "END")
            {
            INPuT:
                commands = Console.ReadLine().Split().ToArray();
                if (commands.Length == 5 && commands[0] == "swap")
                {
                    int x1 = int.Parse(commands[1]);
                    int y1 = int.Parse(commands[2]);
                    int x2 = int.Parse(commands[3]);
                    int y2 = int.Parse(commands[4]);

                    if(x1>rows||y1>cols||x2>rows||x2>cols)
                    {
                        Console.WriteLine("Invalid Input");
                        goto INPuT;
                    }

                    string temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                     {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                            Console.Write(" " + matrix[i, j]);
                            }
                         Console.WriteLine();
                    }


                }
                else if (commands[0] == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    goto INPuT;
                }

            }


        }
    }
}