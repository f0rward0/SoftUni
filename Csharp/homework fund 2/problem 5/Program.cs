using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem__5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] jagged = new char[4][];
            jagged[0] = Console.ReadLine().ToCharArray();
            jagged[1] = Console.ReadLine().ToCharArray();
            jagged[2] = Console.ReadLine().ToCharArray();
            jagged[3] = Console.ReadLine().ToCharArray();

            char[] commands = Console.ReadLine().ToCharArray();
            int horizontal = 0;
            int vertical = 0;
            int coinsCount=0;
            int wallHits = 0;

            for(int i=0;i<commands.Length-1;i++)
            {
                if(commands[i]=='>')
                {
                    if(vertical>=jagged[horizontal].Count())
                    {
                        wallHits++;
                    }
                    else
                    {
                        vertical++;
                    }
                }
                if (commands[i] == '<')
                {
                    if(vertical==0)
                    {
                        wallHits++;
                    }
                    else
                    {
                        vertical--;
                    }
                }
                if (commands[i] == '^')
                {
                    if(horizontal==0)
                    {
                        wallHits++;
                    }
                    else
                    {
                        horizontal--;
                    }
                }
                if (commands[i] == 'V')
                {
                    if(horizontal==3||jagged[horizontal+1].Count()<vertical)
                    {
                        wallHits++;
                    }
                    else
                    {
                        horizontal++;
                    }
                }
                if (jagged[horizontal][vertical] == '$')
                {
                    coinsCount++;
                }
            }
            Console.WriteLine("coins collected: {0}\nWalls hit: {1}", coinsCount, wallHits);

        }
    }
}
