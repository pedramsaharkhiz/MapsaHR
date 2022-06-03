using System;

namespace session7_1
{
    public class Teacher:Person
    {
        public Teacher(string name,int age):base(name,age){
            System.Console.WriteLine($"{name} is {age} ");
        }
        public void Explain(){
            System.Console.WriteLine("and is explaining");
        }
    }
}
