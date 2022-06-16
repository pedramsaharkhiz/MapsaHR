using System;

namespace C
{
    internal class Program
    {
        public static string Result="";
        
        public static string func(int n){//recursive method for calculating binary number
            if(n>=2){
                Result+=Convert.ToString(n%2);
                return func(n/2);
            }else{
                Result+=Convert.ToString(n);
                return Result;            
}
        }
        public static string rev(string s){//reversing string 
            string revres="";
            for(int i=s.Length-1;i>=0;i--){
               revres+=s[i];
            }
            return revres;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            System.Console.WriteLine("Please Enter A Decimal Number ..");
            Console.ForegroundColor=ConsoleColor.Gray;
            int n=Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            System.Console.WriteLine("Here is Result:");
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            System.Console.WriteLine(rev(func(n)));
        }
    }
}

