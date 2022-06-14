using System.Globalization;
using System;

namespace HomeWork7
{

    public class Program
    {
        public static string res="";
        public static string rec(string s,int n){
             
            if(n!=-1){
                res+=s[n];
                return rec(s,n-1);
            }else{
            return res;
            }
            
        }
       
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please Enter a string !");
            string s=Console.ReadLine();
            System.Console.WriteLine("Here is Result : ");
            System.Console.WriteLine(rec(s,s.Length-1));
            
        }
    }
}


