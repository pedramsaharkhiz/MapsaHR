using System;

namespace HomeWork9
{
    public  class Program
    {
        public string Input { get; set; }
        public event EventHandler ev;
        public void Trigger(object sender,EventArgs e){
            List<Person> LP=new List<Person>();   
            LP.Add(new Person{Fname="Pedram",Lname="Saharkhiz",Allowed=true});
            LP.Add(new Person{Fname="Ashkan",Lname="Nasrollahi",Allowed=true});
            LP.Add(new Person{Fname="Benyamin",Lname="Rezazadeh",Allowed=true});
            LP.Add(new Person{Fname="Sheyda",Lname="Aghasi",Allowed=false});
            LP.Add(new Person{Fname="Melika",Lname="Saharkhiz",Allowed=false});
             List<Person> IN=new List<Person>(); 
            IN.Add(new Person{Fname=Input.Split(" ").ElementAt(0),Lname=Input.Split(" ").ElementAt(1)});
            var r=IN.Any(x=>LP.Any(y=>x.CompareTo(y)==1));
            if(r){
            IN.ForEach(x=>LP.Where(y=>(x.CompareTo(y)==1?true:false)).ToList().ForEach(c=>{if(c.Allowed)System.Console.WriteLine($"Welcome {c.Fname} {c.Lname}");if(!c.Allowed) System.Console.WriteLine("Boned!");}));
            }else{
                System.Console.WriteLine("Not Found!");
            }
        }
        
        public void GetName(){
            string Fname;
            string Lname;
            Input=Console.ReadLine();
            ev?.Invoke(this,EventArgs.Empty);
        }
        static void Main(string[] args)
        {
            Program P=new Program();
            P.ev+=P.Trigger;
            P.GetName();
        }
    }
}

