using System;

class Program
{
    static void Main()
    {
        string sWord = Console.ReadLine();
        string eMess = Console.ReadLine();
        string dev=null;
        char[] word, mess,cdev;
        int sum = 0;
        

        word = sWord.ToCharArray();
        mess = eMess.ToCharArray();
        for(int i=0;i<word.Length;i++)
        {
            sum+=word[i];
        }
    OTNOWO:
        int mask = 0;
        dev = sum.ToString();
        cdev = dev.ToCharArray();
        for (int i = 0; i < dev.Length;i++ )
        {
            mask+=(int)char.GetNumericValue(cdev[i]);
        }
        if(mask>9)
        {
            sum = mask;
            goto OTNOWO;
        }
        int[] messHelper=new int[mess.Length];

        for (int i=0; i < mess.Length;i++ )
        {
            messHelper[i] = (int)mess[i];
            if (messHelper[i] % mask == 0)
                messHelper[i] += mask;
            else
                messHelper[i] -= mask;
        }
        for(int i=messHelper.Length-1;i>=0;i--)
        {
           // char c;
            //c =(char)messHelper[i];
            Console.Write("{0}",(char)messHelper[i]);
        }
        Console.Write("\n");
      
    }
}

