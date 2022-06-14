using System.Globalization;
using System;

namespace HomeWork7
{
    public static class class1{
         public static string P(this string s){if(s=="")return "Please Enter Valid String!";else{
            string result="";
            for(int i=s.Length-1;i>=0;i--){
                result+=s[i];
            }
            return result;}
        }

    }
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


