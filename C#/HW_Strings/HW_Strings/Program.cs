using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Strings
{
    class Reverse_String
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Reverse(input));
        }
        static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
