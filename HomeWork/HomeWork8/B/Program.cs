using System;

namespace B
{
    internal class Program
    {
        public static string res="";
        public static string rec(string s,int n){
            if(n!=-1){
                res+=s[n];
                return rec(s,n-1);
            }else{
            return res;}
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            System.Console.WriteLine("Enter ..");
            Console.ForegroundColor=ConsoleColor.Gray;
            string s=Console.ReadLine();
            string res=rec(s,s.Length-1);
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            System.Console.WriteLine("Result : ");
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            if(s==res)System.Console.WriteLine("true");else System.Console.WriteLine("false");
        }
    }
}


