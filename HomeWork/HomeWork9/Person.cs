using System;

namespace HomeWork9
{
    public  class Person:IComparable<Person>
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public bool Allowed { get; set; }

        public int CompareTo(Person? other)
        {
            if(this.Fname==other.Fname&&this.Lname==other.Lname){
                return 1;
            }else return 0;
        }
    }
}