using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace problem_5
{
    class Slice_And_Assemble_And_Compress
    {
        static void Main(string[] args)
        {
            Slice("Text.txt", "../../", 5);
            Assemble(5);
        }

        public static void Slice(string sourceFile, string destination, int parts)
        {
            byte[] buffer = new byte[4096];
            DirectoryInfo directorySelected = new DirectoryInfo(destination);
            using (Stream originalFile = File.OpenRead(sourceFile))
            {
                int index = 1;
                while (originalFile.Position < originalFile.Length)
                {

                    using (Stream compressedFile = File.Create(destination + "\\" + index + ".gz"))
                    {
                        using (GZipStream compression = new GZipStream(compressedFile, CompressionMode.Compress))
                        {
                            int byteCounter = 0;
                            while (byteCounter < originalFile.Length / parts)
                            {
                                int bytesRead = originalFile.Read(buffer, 0, buffer.Length);

                                if (bytesRead == 0)
                                {
                                    break;
                                }
                                byteCounter += bytesRead;

                                compression.Write(buffer, 0, bytesRead);
                            }
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
                string source = String.Format("../../{0}.gz", i);
                FileStream partOfFile = new FileStream(source, FileMode.Open);
                FileStream assembledFile = new FileStream("../../assembled.txt", FileMode.Append);

                using (partOfFile)
                {
                    using (assembledFile)
                    {
                        using (GZipStream decompression = new GZipStream(partOfFile, CompressionMode.Decompress))
                        {
                            while (true)
                            {
                                int bytesRead = decompression.Read(buffer, 0, buffer.Length);
                                if (bytesRead == 0)
                                {
                                    break;
                                }
                                assembledFile.Write(buffer, 0, bytesRead);
                            }
                        }


                    }
                }
            }
        }
    }
}
