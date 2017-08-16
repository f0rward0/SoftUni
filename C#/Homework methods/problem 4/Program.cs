using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4
{
    class Program
    {
        static int GetIndexOfFirstElementLargerThanNeighbours(int[] arr)
        {
            if (arr[0] > arr[1])
                return 0;
            else
            {
                int i;
                for(i=1;i<arr.Length-1;i++)
                {
                    if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                    {
                        break;
                    }
                }
                if (arr[i] > arr[i - 1])
                    return i;
                else
                    return -1;
            }

        }
        static void Main(string[] args)
        {
            int[] seqOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] seqTwo = {1,2,3,4,5,6,6};
            int[] seqThree = { 1,1,1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(seqOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(seqTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(seqThree));
        }
    }
}
