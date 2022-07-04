using System;

namespace HomeWork10
{
    public class Program
    {
        static void Main(string[] args)
        {
            int [,] A=new int [3,3]{{1,2,3},{4,5,6},{7,8,9}};
            for(int i=0;i<3;i++){
                for(int j=0;j<3;j++){
                    System.Console.Write($" {A[i,j]} ");
                }
                System.Console.WriteLine();
               
            }
        }
    }
}


