using System;

class Program
{
    static void Main(string[] args)
    {
        double FG,FGA,P3P,TOV,ORB,OppDRB,FT,FTA;
        double eFG, pTOV, pORB, pFT;

        FG = double.Parse(Console.ReadLine());
        FGA = double.Parse(Console.ReadLine());
        P3P = double.Parse(Console.ReadLine());
        TOV = double.Parse(Console.ReadLine());
        ORB = double.Parse(Console.ReadLine());
        OppDRB = double.Parse(Console.ReadLine());
        FT = double.Parse(Console.ReadLine());
        FTA = double.Parse(Console.ReadLine());

        eFG = (FG + 0.5 * P3P) / FGA;
        pTOV = TOV / (FGA + 0.44 * FTA + TOV);
        pORB = ORB / (ORB + OppDRB);
        pFT = FT / FGA;

        Console.WriteLine("eFG% {0:F3}", eFG);
        Console.WriteLine("TOV% {0:F3}", pTOV);
        Console.WriteLine("ORB% {0:F3}", pORB);
        Console.WriteLine("FT% {0:F3}", pFT);


    }
 }
