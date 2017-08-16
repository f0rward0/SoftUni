using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            List<string> list=new List<string>();
            list.AddRange(arr);
            double output = 0;
            if(arr.Contains("*")||arr.Contains("/"))
            {
                for(int i=1;i<list.Count;i++)
                {
                    if(list[i]=="*")
                    {
                        list[i-1]=(double.Parse(list[i-1])*double.Parse(list[i+1])).ToString();
                        list.RemoveRange(i, 2);
                        list.Add("0");
                        list.Add("0");
                        i = 1;
                    }
                    if (list[i] == "/")
                    {
                        list[i-1] = (double.Parse(list[i - 1]) / double.Parse(list[i + 1])).ToString();
                        list.RemoveRange(i, 2);
                        list.Add("0");
                        list.Add("0");
                        i = 1;
                    }
                   
                }

            }
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i-1] == "+")
                {
                    list[i-1] = (double.Parse(list[i - 1]) + double.Parse(list[i + 1])).ToString();
                    list.RemoveRange(i, 2);
                    list.Add("0");
                    list.Add("0");
                    i = 1;
                }
                if (list[i-1] == "-")
                {
                    list[i] = (double.Parse(list[i - 1]) - double.Parse(list[i + 1])).ToString();
                    list.RemoveRange(i, 2);
                    list.Add("0");
                    list.Add("0");
                    i = 1;
                }
            }
            Console.WriteLine(list[0]);
            
        }
    }
}
