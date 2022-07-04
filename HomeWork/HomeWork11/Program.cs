namespace HomeWork11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Table t=new Table();
            
            List<Table>lstName=new List<Table>();
            System.Console.WriteLine("Please Enter Your name and Your Friend Name :");
            System.Console.WriteLine("Your Name :");
            string s=Console.ReadLine();
            lstName.Add(new Table{Name=s});
            System.Console.WriteLine("Your Friend Name :");
            s=Console.ReadLine();
            lstName.Add(new Table{Name=s});
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine($"\n\nWelcome {lstName[0].Name} and {lstName[1].Name}, Here is XO Game \n\n ");
            Console.ForegroundColor=ConsoleColor.Red;
            System.Console.Write($"{lstName[0].Name} is X ");
            Console.ForegroundColor=ConsoleColor.Blue;
            System.Console.Write($"  {lstName[1].Name} is O");
            //
            int i=0;
           
            while (t.Finish==false)
            {
             Console.Clear();
             
             Console.ForegroundColor=ConsoleColor.Red;
             System.Console.Write($"{lstName[0].Name} is X ");
             Console.ForegroundColor=ConsoleColor.Blue;
             System.Console.Write($"  {lstName[1].Name} is O");
             t.Show(i%2);
             if(i%2==0)Console.ForegroundColor=ConsoleColor.Red;else Console.ForegroundColor=ConsoleColor.Blue;
             System.Console.WriteLine($"{lstName[i%2].Name} : \n"); 
             int n=Convert.ToInt32(Console.ReadLine());
             t.Set(n,i%2);
             if(t.Flag==false){System.Console.WriteLine($"\nHey {lstName[i%2].Name} Please Enter a Valid Value :\n");
             n=Convert.ToInt32(Console.ReadLine());
             t.Set(n,i%2);}
             Console.Clear();
             t.Show(i%2);
            if(t.check()==1){Console.ForegroundColor=ConsoleColor.DarkGreen;System.Console.WriteLine($"{lstName[1].Name} is win");break;}
            else if(t.check()==0){Console.ForegroundColor=ConsoleColor.DarkGreen;System.Console.WriteLine($"{lstName[0].Name} is win");break;}else{i++;}
            if(i==9){Console.ForegroundColor=ConsoleColor.DarkYellow;System.Console.WriteLine("Draw!");break;}

            }
            

        }
    }
}

