using System;


class Program
{
    static void Main(string[] args)
    {
        int temp = 0;
        string values = Console.ReadLine();
        string[] items = values.Split(' ');
        int[] arr = new int[items.Length];
        for (int i = 0; i < items.Length; i++)
        {
            arr[i] = int.Parse(items[i]);
        }



        for (int write = 0; write < arr.Length; write++)
        {
            for (int sort = 0; sort < arr.Length - 1; sort++)
            {
                if (arr[sort] > arr[sort + 1])
                {
                    temp = arr[sort + 1];
                    arr[sort + 1] = arr[sort];
                    arr[sort] = temp;
                }
            }
        }
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();

    }
}
