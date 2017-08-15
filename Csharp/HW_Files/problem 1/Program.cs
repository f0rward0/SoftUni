using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_Files
{
    using System.IO;
    
    class Odd_Lines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Text.txt");
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    
                    if(lineNumber%2!=0)
                    {
                        Console.WriteLine("{0} {1}", lineNumber, line);
                    }
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
            


           
       


        }
    }
}
