using System.Xml;
using System;

namespace HomeWork12
{
    public class Calculator:Cards
    {
        
        public string Generate(){
            Random rnd = new Random();
            int Number   = rnd.Next(2,14); 
            return No.ElementAt(Number).Key;
        }
    }
}