using System;

namespace session7
{
    public class Shape
    {
        private int _x;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y;
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        
        public Shape(int x,int y){
            this.X=x;
            this.Y=y;
        }
        public virtual void CalArea(){
            System.Console.WriteLine("Area is : ");
        }
    }
}
