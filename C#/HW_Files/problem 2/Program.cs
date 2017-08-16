using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace problem_2
{
    class Write_To_File_count
    {
        static void Main(string[] args)
        {
            int counter = 0;
            using (var reader = new StreamReader("../../Text.txt"))
            {
                using (var writer = new StreamWriter("../../counter.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {

                        writer.WriteLine("Line:{0} {1}", counter, line);
                        line = reader.ReadLine();
                        counter++;
                    }
                }
            }

            

        }
    }
}
