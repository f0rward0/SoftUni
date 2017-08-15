using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class replace_a_Tag
{
    static void Main(string[] args)
    {

        string input = Console.ReadLine();
        string pattern = @"<a href=('|"")(http:\/\/\w+\.\w+)\1>(\w+)<\/a>";

        Regex regex = new Regex(pattern);
        string result = regex.Replace(input, @"[URL href=$2]$3[/URL]");

        Console.Clear();
        Console.WriteLine(result);
    }
}

