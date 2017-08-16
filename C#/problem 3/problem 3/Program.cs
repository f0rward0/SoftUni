using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}",new string(' ',(2*n-n-1)/2),new string('*',(n+1)));
        for (int i = 0; i < 2*n-n-2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(' ', (2 * n - n - 1) / 2), new string(' ', (n - 1)));
        }
        for (int i = 0; i < 2 * n - n - 1;i++ )
        {
            Console.WriteLine("{0}*{1}*{0}",new string(' ',(2*n-n-1)/2-i),new string(' ',n-1+2*i));
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('.', 2 * n - 2));
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('@', 2 * n - 2));
        }
        Console.WriteLine("{0}",new string('*', 2 * n));
        
        


    }
}

