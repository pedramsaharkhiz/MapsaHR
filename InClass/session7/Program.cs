using System;

namespace session7
{
    public class Rectangle:Shape{
        public Rectangle(int x,int y):base(x,y){
            
        }
        public override void CalArea()
        {
            base.CalArea();
            System.Console.WriteLine(X*Y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());
            Rectangle R=new Rectangle(x,y);
            R.CalArea();
        }
    }
}

