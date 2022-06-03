using System;

namespace session7_1
{
    public class Student:Person
    {
        public Student(string name,int age):base(name,age){
            System.Console.WriteLine($"{name} is {age} ");
        }
        public void Study(){
            System.Console.WriteLine("and is studying");
        }
        
    }
}
