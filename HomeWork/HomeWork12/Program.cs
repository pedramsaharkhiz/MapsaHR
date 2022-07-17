using System.Globalization;
using System;

namespace HomeWork12
{
    public class Program
    {
        public Program(){
           List<Cards> lstcard=new List<Cards>();
           lstcard.Add(new Cards{Type="Diamond"});
           lstcard.Add(new Cards{Type="Heart"});
           lstcard.Add(new Cards{Type="Club"});
           lstcard.Add(new Cards{Type="Spade"});
        }
        static void Main(string[] args)
        {
            Cards cd=new Cards();
            Calculator cl=new Calculator();
            System.Console.WriteLine(cl.Generate()); 
            
        
        
        

           
           
        }
    }
}

