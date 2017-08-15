using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                long num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException("Number should be positive or 0.");
                }

                Console.WriteLine("Square root of {0} is {1}",num,Math.Sqrt(num));
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
