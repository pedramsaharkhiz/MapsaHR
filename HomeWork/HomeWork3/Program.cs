using System;

namespace HomeWork3
{
    internal class Program
{
static void Main(string[] args)
{
string S1="";
string S2="";
System.Console.WriteLine("S1 :");
S1=Console.ReadLine()+"";
System.Console.WriteLine("S2:");
S2=Console.ReadLine()+"";
char ch=S1[0];
bool b=true,c=false;
for(int i=0;i<=S2.Length-S1.Length;i++){
    if(S2[i]==ch){b=true;
        for(int n=i;n<S1.Length+i;n++){
            if(S2[n]!=S1[n-i]){b=false; break;}
        }
        if(b){System.Console.WriteLine($"Yes ,I Found it start index at {i}");c=true;}
    }
    
}
if(!c)System.Console.WriteLine("Oops ,Not Found!");
        }
    }
}