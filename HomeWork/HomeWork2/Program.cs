using System;

namespace HomeWork2 
{
     class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter Your Number ... ");
            int n=Convert.ToInt32(System.Console.ReadLine());
            int t=0;
            for(int i=1;i<=n;i++){
                if(i%2!=0)t+=i;
            }
            System.Console.WriteLine($"Summation of odds numbers from 1 to {n} is : {t}");
        }
    }
}