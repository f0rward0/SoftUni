using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;


class Program
{
    static void Main()
    {
        string path = Console.ReadLine();

        var extentions = new SortedDictionary<string, Dictionary<string, double>>();
        DirectoryInfo directory = new DirectoryInfo(path);

        foreach (var file in directory.GetFiles())
        {
            if (extentions.ContainsKey(file.Extension))
            {
                extentions[file.Extension].Add("--" + file.Name + " - ", file.Length);
            }
            else
            {
                extentions.Add(file.Extension, new Dictionary<string, double> { { file.Name, file.Length } });
            }
        }

        var result = extentions.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key);
        using (var writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt"))
        {
            foreach (var extention in result)
            {
                writer.WriteLine(extention.Key);
                var sortedSubDict = extention.Value.OrderBy(p => p.Value);
                foreach (var pair in sortedSubDict)
                {
                    writer.WriteLine("--{0} - {1:F3}kb", pair.Key, pair.Value / 1024);
                }
            }
        }
    }
}
