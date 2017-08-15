using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution  
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        var ROW=new string[H];
        for (int i = 0; i < H; i++)
        {
            ROW[i] = Console.ReadLine();
        }

        int rolls=H;
        int colls = 27 * L;
        
        char[][] matrix=new char[rolls][];

        for (int i = 0; i < H; i++)
        {
            matrix[i] = ROW[i].ToCharArray();
        }

        StringBuilder sb=new StringBuilder();

        char[] arr = T.ToUpper().ToCharArray();
        int letter=0;
      

        for (int i = 0; i < H; i++)
        {
            for (int k = 0; k < arr.Length;k++ )
            {
                if (arr[k] >= 65 && arr[k] <= 90)
                {
                    letter = (arr[k] - 65) * L;
                    for (int j = letter; j < letter + L; j++)
                    {
                        Console.Write(matrix[i][j]);
                       
                   
                    }

                }
                else
                {
                    letter = 26 * L;
                    for (int j = letter; j < letter + L; j++)
                    {
                        Console.Write(matrix[i][j]);


                    }
                }



            }

            Console.WriteLine();
        }

    }
}