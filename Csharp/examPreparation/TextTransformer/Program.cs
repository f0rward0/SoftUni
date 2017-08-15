using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextTransformer
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            
            string burpCheck=Console.ReadLine();
            //burpCheck= Regex.Replace(burpCheck, @"\s+", " ");

            List<char> output = new List<char>();

            while(burpCheck!="burp")
            {

                input.Append(burpCheck);
                burpCheck = Console.ReadLine();
                //burpCheck = Regex.Replace(burpCheck, @"\s+", " ");
            }

            char[] carr =input.ToString().ToCharArray();
            for (int i = 0; i < carr.Length; i++)
            {
                int counter = 0;
                if (carr[i]=='$')
                {
                    for (int j = i+1; j < carr.Length; j++)
                    {
                        if (carr[j] == '$')
                        {
                            carr[j]='9';
                            int weight = 1;
                            counter = 0;
                            for (int k = i + 1; k < j; k++)
                            {
                                if (counter % 2 == 0)
                                {
                                    carr[k] += (char)weight;
                                    output.Add(carr[k]);
                                    

                                }
                                else
                                {
                                    carr[k] -= (char)weight;
                                    output.Add(carr[k]);

                                }
                                counter++;
                            }
                            break;
                        }
                        
                    }

                    
                }


                if (carr[i] == '%')
                {
                    for (int j = i + 1; j < carr.Length; j++)
                    {
                        if (carr[j] == '%')
                        {
                            carr[j] = '9';
                            int weight = 2;
                            counter = 0;
                            for (int k = i + 1; k < j; k++)
                            {
                                if (counter % 2 == 0)
                                {
                                    carr[k] += (char)weight;
                                    output.Add(carr[k]);


                                }
                                else
                                {
                                    carr[k] -= (char)weight;
                                    output.Add(carr[k]);

                                }
                                counter++;
                            }
                            break;
                        }

                    }


                }


                if (carr[i] == '&')
                {
                    for (int j = i + 1; j < carr.Length; j++)
                    {
                        if (carr[j] == '&')
                        {
                            carr[j] = '9';
                            int weight = 3;
                            counter = 0;
                            for (int k = i + 1; k < j; k++)
                            {
                                if (counter % 2 == 0)
                                {
                                    carr[k] += (char)weight;
                                    output.Add(carr[k]);


                                }
                                else
                                {
                                    carr[k] -= (char)weight;
                                    output.Add(carr[k]);

                                }
                                counter++;
                            }
                            break;
                        }

                    }


                }
                i += counter;

                
            }
            StringBuilder outputstr = new StringBuilder();
            for (int i = 0; i < output.Count; i++)
            {
                outputstr.Append(output[i]);
            }
            Console.WriteLine(outputstr.ToString());
        }
    }
}
