using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class Program
{
    static void Main()
    {
        using (var wordReader = new StreamReader("../../Words.txt"))
        {
            using (var textReader = new StreamReader("../../Text.txt"))
            {
                using (var writer = new StreamWriter("../../results.txt"))
                {
                    Dictionary<string, int> words = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
                    string buffer = wordReader.ReadLine();
                    while (buffer != null)
                    {
                        words[buffer] = 0;
                        buffer = wordReader.ReadLine();
                    }

                    buffer = textReader.ReadLine();
                    while (buffer != null)
                    {
                        string[] wordsFromBuffer = buffer.Split(new char[] { ' ', ',', '-', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);


                        foreach (var wordFromBuffer in wordsFromBuffer)
                        {
                            if (words.ContainsKey(wordFromBuffer))
                            {
                                words[wordFromBuffer]++;
                            }
                        }
                        buffer = textReader.ReadLine();
                    }

                    foreach (var pair in words.OrderBy(p => p.Value))
                    {
                        writer.WriteLine("{0} - {1}", pair.Key, pair.Value);
                    }
                }
            }
        }

    }
}