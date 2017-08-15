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
            var input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            var matrix = new char[input[0]] [];
            int lastj=0;
            int lastk=0;
            for (int i = 0; i < input[0]; i++)
            {
                matrix[i]=Console.ReadLine().ToCharArray();
            }
            
            var commands=Console.ReadLine().ToCharArray();


			for (int i = 0; i < commands.Length; i++)
			{
			    for (int j = 0; j <input[0]; j++)
			    {
			        for (int k = 0; k < input[1]; k++)
			        {
			            if(matrix[j][k]=='P')
                        {
                            if(commands[i]=='L')
                            {
                                if (!(k == 0))
                                {
                                    if (matrix[j][k - 1] == 'B')
                                    {
                                        lastj = j;
                                        lastk = k-1;
                                        goto FINISH;
                                    }
                                    else
                                    {
                                        matrix[j][k] = '.';
                                        matrix[j][k - 1] = 'P';
                                    }
                                }
                            }
                            
                            if (commands[i] == 'R')
                            {
                                    if(k!=input[0])
                                    {
                                        if (matrix[j][k + 1] == 'B')
                                        {
                                            lastj = j;
                                            lastk = k+1;
                                            goto FINISH;
                                        }
                                        else
                                        {
                                            matrix[j][k] = '.';
                                            matrix[j][k + 1] = 'P';
                                        }
                                    }
                            }
                            
                             
                            if(commands[i]=='U')
                            {
                                if(j!=0)
                                {
                                if(matrix[j-1][k]=='B')
                                {
                                    lastj = j-1;
                                    lastk = k;
                                    goto FINISH;
                                }
                                else
                                {
                                    matrix[j][k]='.';
                                    matrix[j-1][k]='P';
                                }
                                }
                            }
                            if(commands[i]=='D')
                            {
                                if (j != input[0])
                                {
                                    if (matrix[j + 1][k] == 'B')
                                    {
                                        lastj = j+1;
                                        lastk = k;
                                        goto FINISH;
                                    }
                                    else
                                    {
                                        matrix[j][k] = '.';
                                        matrix[j + 1][k] = 'P';
                                    }
                                }
                             }
                        }

			        }
			    
                }
                for (int j = 0; j < input[0]; j++)
			    {
			        for (int k = 0; k < input[1]; k++)
			        {
			            if(matrix[j][k]=='B')
                        {
                            if (!(k == input[1] - 1))
                            {
                                if (!(matrix[j][k + 1] == 'B'))
                                {
                                    matrix[j][k + 1] = 'G';
                                }
                            }
                            if (!(k == 0))
                            {
                                if (!(matrix[j][k - 1] == 'B'))
                                {
                                    matrix[j][k - 1] = 'G';
                                }
                            }
                            if (!(j == input[0] - 1))
                            {
                                if (!(matrix[j + 1][k] == 'B'))
                                {
                                    matrix[j + 1][k] = 'G';
                                }
                            }
                            if(!(j==0))
                            {
                                if (!(matrix[j - 1][k] == 'B'))
                                {
                                    matrix[j - 1][k] = 'G';
                                }
                            }
                        }
			        }
			    }
                for (int j = 0; j < input[0]; j++)
			    {
			        for (int k = 0; k < input[1]; k++)
			        {
                        if(matrix[j][k]=='G')
                            matrix[j][k]='B';
                    }
                }
			}

            for (int j = 0; j < input[0]; j++)
            {
                for (int k = 0; k < input[1]; k++)
                {
                    if (matrix[j][k] == 'P')
                    {
                        matrix[j][k] = '.';
                        lastj = j;
                        lastk=k;
                    }
                    Console.Write(matrix[j][k]);
                }
                Console.WriteLine();
            }


            
                Console.WriteLine("won: {0} {1}", lastj, lastk);
        goto END;

                    
        FINISH:
        for (int j = 0; j < input[0]; j++)
        {
            for (int k = 0; k < input[1]; k++)
            {
                if (matrix[j][k] == 'B')
                {
                    if (!(k == input[1] - 1))
                    {
                        if (!(matrix[j][k + 1] == 'B'))
                        {
                            matrix[j][k + 1] = 'G';
                        }
                    }
                    if (!(k == 0))
                    {
                        if (!(matrix[j][k - 1] == 'B'))
                        {
                            matrix[j][k - 1] = 'G';
                        }
                    }
                    if (!(j == input[0] - 1))
                    {
                        if (!(matrix[j + 1][k] == 'B'))
                        {
                            matrix[j + 1][k] = 'G';
                        }
                    }
                    if (!(j == 0))
                    {
                        if (!(matrix[j - 1][k] == 'B'))
                        {
                            matrix[j - 1][k] = 'G';
                        }
                    }
                }
            }
        }

        for (int j = 0; j < input[0]; j++)
        {
            for (int k = 0; k < input[1]; k++)
            {
                if (matrix[j][k] == 'G')
                    matrix[j][k] = 'B';
            }
        }


                for (int j = 0; j < input[0]; j++)
                {
                    for (int k = 0; k < input[1]; k++)
                    {
                        Console.Write(matrix[j][k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("dead: {0} {1}", lastj, lastk);
            END:
            int c=0;
        
        
        }
    }
    

}
