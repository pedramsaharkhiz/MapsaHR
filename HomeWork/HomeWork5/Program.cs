using System.Globalization;
using System;
using System.Collections.Generic;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Person>prs=new List <Person>();
            string name;
            int age,salaryperhour;
            for(int i=1;i<=5;i++){
                System.Console.WriteLine($"person {i} : ");
                System.Console.Write("Name : ");
                name=Console.ReadLine()+"";
                System.Console.Write("Age : ");
                age=Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Salary Per Hour : ");
                salaryperhour=Convert.ToInt32(Console.ReadLine());
                prs.Add(new Person(){Name=name,Age=age,SalaryPerHour=salaryperhour});
                System.Console.WriteLine($"* {prs[i-1].Name} is {prs[i-1].Age} and earns {prs[i-1].Cal()} dollars per month !"); 
                System.Console.WriteLine("-----------------------------------");
            }
        }
    }
}


