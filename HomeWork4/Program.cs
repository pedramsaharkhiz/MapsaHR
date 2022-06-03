using System;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S="";
            System.Console.WriteLine("enter your large number ");
            S=Console.ReadLine()+"";
            System.Console.WriteLine("enter your single number ");
            string n=Console.ReadLine()+"";
            int t=0;
            for(int i=0;i<S.Length;i++)
            {
                System.Console.WriteLine(S[i]);
                if(S[i].ToString()==n)t++;
            }
            System.Console.WriteLine($"-{n}- is {t} times repeated in -{S}-");
        }
    }
}