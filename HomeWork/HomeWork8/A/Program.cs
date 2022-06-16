using System;

namespace A
{
    internal class Program
    {
        public static int Result=1;
        public static int cal(int n,int p){
            if(p>0){
                Result*=n;
                return cal(n,p-1);
            }else{
                return Result;
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            System.Console.WriteLine("Enter Your Number ..");
            Console.ForegroundColor=ConsoleColor.Gray;
            int n=Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            System.Console.WriteLine("Enter Your Power Value ..");
            Console.ForegroundColor=ConsoleColor.Gray;
            int p=Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            System.Console.WriteLine("Result : ");
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            System.Console.WriteLine(cal(n,p));
        }
    }
}

