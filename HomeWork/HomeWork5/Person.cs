using System;

namespace HomeWork5
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value;} 
        }
        private int _salaryperhour;
        public int SalaryPerHour 
        {
            get { return _salaryperhour; }
            set { if(value==0){System.Console.WriteLine("Error!");}else{ _salaryperhour = value;} }
        }
        public int Cal(){
            int TotalSalary=SalaryPerHour*8*30;
            return TotalSalary;
        }
    }
}
