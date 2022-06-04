using System.Globalization;
using System;
using System.Text;

namespace HomeWork6
{
    public class Program
    {
            
            
         static public string generate(){//method for generate a random name
            List<string> str=new List<string>();
            str.Add("pedram");
            str.Add("mohsen");
            str.Add("kasra");
            str.Add("ashkan");
            str.Add("sheyda");
            str.Add("melika");
            str.Add("hamid");
            str.Add("sanaz");
            Random rnd=new Random();
            int n=rnd.Next(str.Count);
            return str[n];
        }
        
        static void Main(string[] args)
        {
            ///welcome message
        Console.ForegroundColor=ConsoleColor.DarkBlue;
        System.Console.WriteLine("------- Welcome To HangMan -------");
        ///
         string s,fls="",ltr="";//s for random name , fls for false guessed letters,ltr for all guessed letters
         char ch;//ch for guessed letters given from user
         s=generate();//call above method
         List<char> tru=new List<char>();//list for true letters
         string blank="";//blank is a string that contains - characters to showing what letters are true in total(game status)
         for(int i=1;i<=s.Length;i++){blank+="-";}//put - characters to blank string 
         int tt=0,tf=0;//tf for counting true guesses and tf for counting false guesses
         ///
         string [] ex=new string[8];//ex array for scenes of execution
         ex[0]=@"  +———+
      |
      |
      |
      |
     ===";
        ex[1]=@"  +———+
  O   |
      |
      |
      |
     ===";
        ex[2]=@"  +———+
  O   |
  |   |
      |
      |
     ===";
        ex[3]=@"  +———+
  O   |
  |/  |
      |
      |
     ===";
        ex[4]=@"  +———+
  O   |
 \|/  |
      |
      |
     ===";
        ex[5]=@"  +———+
  O   |
 \|/  |
 /    |
      |
     ===";
        ex[6]=@"  +———+
  O   |
 \|/  |
 / \  |
      |
     ===";
         ///
         for (int i = 1; i <= 6; i++)//loop for 6 times given to user to guess
         {
            ///
            Console.ForegroundColor=ConsoleColor.Cyan;
            System.Console.WriteLine($"Letters Guessed So Far : {ltr}");
            ///
            Console.ForegroundColor=ConsoleColor.Red;
            System.Console.WriteLine($"False Letters : {fls}");
            ///
            Console.ForegroundColor=ConsoleColor.Yellow;
            System.Console.Write("Guess a Letter : ");
            ///
            Console.ForegroundColor=ConsoleColor.Gray;
            ch=Convert.ToChar(Console.ReadLine());//give user guess letter
            ///
            ltr+=ch+" ";//adding a letter for all guesses
            if(s.Contains(ch)){//check if the name contains guessed letter or not
            tt++;//add true counter variable tt
            tru.Add(ch);//add letter to true letters list
            for(int j=0;j<s.Length;j++){//loop for check game status by blank variable
                if(s[j]==ch){
                    StringBuilder sb = new StringBuilder(blank);
                    sb[j]=ch;
                    blank = sb.ToString();
                }
            }
            }else{//if letter was false
                tf++;//add false counter variable tf
                fls+=ch+" ";//add letter to false letters list
            }
            ///
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine(blank);//show game status
            ///
            Console.ForegroundColor=ConsoleColor.DarkGray;
            System.Console.WriteLine(ex[tf]);//show scenes of execution
            ///
            Console.ForegroundColor=ConsoleColor.Gray;
            System.Console.WriteLine("--------------------");//separate game loops from each other 
            ///check game status and show appropriate message
            if(tt==s.Length){Console.ForegroundColor=ConsoleColor.DarkGreen;System.Console.WriteLine("You Win !");break;}
            if(i==6){Console.ForegroundColor=ConsoleColor.Red;System.Console.WriteLine("Game Over!");}
         } 
            Console.ForegroundColor=ConsoleColor.Gray;  
            System.Console.WriteLine("By Pedram Saharkhiz :)");
        }
    }
}
            
        
             

