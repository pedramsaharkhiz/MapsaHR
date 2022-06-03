using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
        int tab=5;    
        for(int i=1;i<=5;i++){
            tab--;
            for(int t=1;t<=tab;t++){
                System.Console.Write(" ");
            }
            for(int j=1;j<=i;j++){
                System.Console.Write(j);
            }
            for(int k=i-1;k>=1;k--){
                System.Console.Write(k);
            }
            System.Console.WriteLine();
        }
        }
    }
}
