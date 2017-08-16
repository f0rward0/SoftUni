using System;

class Program
{
    static void Main(string[] args)
    {
        string sWord = Console.ReadLine();
        string eMes = Console.ReadLine();
        int sum=0,mask=0;
        int[] maskArr=null;
        string sSum;
        char[] word, mess,cSum;
        word = sWord.ToCharArray();
        mess = eMes.ToCharArray();
        for(int i=0;i<word.Length;i++)
        {
            sum += word[i];
        }
        sSum = sum.ToString();
        cSum = sSum.ToCharArray();
        

        for(int i=0;i<cSum.Length;i++)
        {
            maskArr[i] = Convert.ToInt32(cSum[i]);

        }
        
        





    }
}

