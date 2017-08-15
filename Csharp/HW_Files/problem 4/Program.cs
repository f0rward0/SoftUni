using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace problem_4
{
    class Copy_File
    {
        static void Main()
        {
            FileStream File = new FileStream("../../Stickman.png", FileMode.Open);
            FileStream copy = new FileStream("../../copiedImage.png", FileMode.Create);

            using (File)
            {
                using (copy)
                {

                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = File.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        copy.Write(buffer, 0, readBytes);
                    }
                }
            }

        }
    }
}
    

