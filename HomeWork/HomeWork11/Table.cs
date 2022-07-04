namespace HomeWork11
{
    public class Table
    {
     
    public string Name { get; set; }
    public bool Finish { get; set; }
    public bool Flag { get; set; }
    public string [,] A=new string [3,3]{{"1","2","3"},{"4","5","6"},{"7","8","9"}};
    string str = new string('-', 21);
    //
    public int check(){int win=-1;
    for (int i = 0; i < 3; i++)
     {
            if(A[i,0]=="X"&&A[i,1]=="X"&&A[i,2]=="X")win=0;
            if(A[i,0]=="O"&&A[i,1]=="O"&&A[i,2]=="O")win=1;
            //
            if(A[0,i]=="X"&&A[1,i]=="X"&&A[2,i]=="X")win=0;
            if(A[0,i]=="O"&&A[1,i]=="O"&&A[2,i]=="O")win=1;
     }
    if(A[1,1]=="X"&&A[2,2]=="X"&&A[0,0]=="X")win=0;
    if(A[1,1]=="O"&&A[2,2]=="O"&&A[0,0]=="O")win=1;
    //
    if(A[0,2]=="X"&&A[1,1]=="X"&&A[2,0]=="X")win=0;
    if(A[0,2]=="O"&&A[1,1]=="O"&&A[2,0]=="O")win=1;
        return win;
    }
    //
    public void Set(int n,int Turn){
        this.Flag=false;
        
        for (int i = 0; i < 3; i++)
     {
        for (int j = 0; j < 3; j++)
        {
            if(A[i,j]==n.ToString()){this.Flag=true;if(Turn==0)A[i,j]="X";else A[i,j]="O";}
            
        }
     }
    }
    //
     public void Show(int Turn){
         int x;
      Console.ForegroundColor=ConsoleColor.Gray; 
     System.Console.WriteLine($"\n");                
     for (int i = 0; i < 3; i++)
     {
        for (int j = 0; j < 3; j++)
        {
            if(int.TryParse(A[i,j],out x)){
            if((j==0||j==1)){System.Console.Write($"{this.A[i,j]}");Console.ForegroundColor=ConsoleColor.Gray;System.Console.Write("    |    ");}else System.Console.Write($"{this.A[i,j]}       ");}
            else{
            if((j==0||j==1)){
            if(A[i,j]=="X")Console.ForegroundColor=ConsoleColor.Red;else Console.ForegroundColor=ConsoleColor.Blue;System.Console.Write($"{this.A[i,j]}");Console.ForegroundColor=ConsoleColor.Gray;System.Console.Write("    |    ");}
            else {if(A[i,j]=="X")Console.ForegroundColor=ConsoleColor.Red;else Console.ForegroundColor=ConsoleColor.Blue;System.Console.Write($"{this.A[i,j]}       ");}}
            Console.ForegroundColor=ConsoleColor.Gray;
        }
        if(i==0||i==1){System.Console.Write($"\n     |         |"); System.Console.WriteLine($"\n{str}");System.Console.WriteLine("     |         |");}else {System.Console.WriteLine($"\n");}
     } 
      
    

     }
    }
}