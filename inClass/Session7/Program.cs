using System;

namespace session7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student>st=new List<Student>();
            List<Teacher>te=new List<Teacher>();
            System.Console.WriteLine("teacher: ");
            System.Console.WriteLine("enter name : ");
            string? name=Console.ReadLine();
            System.Console.WriteLine("enter age : ");
            int age=Convert.ToInt32(Console.ReadLine());
            te.Add(new Teacher(name,age){});
            te[0].Explain();
            System.Console.WriteLine("students :");
            for(int i=0;i<5;i++){
                System.Console.WriteLine("enter name : ");
                name=Console.ReadLine();
                System.Console.WriteLine("enter age : ");
                age=Convert.ToInt32(Console.ReadLine());
                st.Add(new Student(name,age){});
                st[i].Study();
            }
        }
    }
}

