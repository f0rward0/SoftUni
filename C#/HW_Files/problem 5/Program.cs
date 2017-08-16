using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace problem_5
{
    class Slice_And_Assemble
    {
        static void Main(string[] args)
        {
            Slice("Text.txt", "../../", 5);
            Assemble(5);
        }

        public static void Slice(string sourceFile, string destination, int parts)
        {
            byte[] buffer = new byte[4096];

            using (Stream input = File.OpenRead(sourceFile))
            {
                int index = 1;
                while (input.Position < input.Length)
                {

                    using (Stream output = File.Create(destination + "\\" + index + ".txt"))
                    {

                        int bytecounter = 0;
                        while (bytecounter < input.Length / parts)
                        {
                            int bytesRead = input.Read(buffer, 0, buffer.Length);

                            if (bytesRead == 0)
                            {
                                break;
                            }
                            bytecounter += bytesRead;
                            output.Write(buffer, 0, bytesRead);
                        }

                    }
                    index++;
                }
            }
        }

        public static void Assemble(int parts)
        {
            byte[] buffer = new byte[4096];
            for (int i = 1; i <= parts; i++)
            {
                string source = String.Format("../../{0}.txt", i);
                FileStream partOfFile = new FileStream(source, FileMode.Open);
                FileStream assembledFile = new FileStream("../../assembled.txt", FileMode.Append);

                using (partOfFile)
                {
                    using (assembledFile)
                    {
                        int bytesRead;
                        while ((bytesRead = partOfFile.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            assembledFile.Write(buffer, 0, bytesRead);
                        }

                    }
                }
            }
        }
    }
}
