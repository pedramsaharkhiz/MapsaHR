using System.Collections.Generic;
using System;

namespace HomeWork12
{
    public class Cards
    {
        public string Type { get; set; }
        public Dictionary<string,int> No=new Dictionary<string, int>(){
            {"two",2},
            {"three",3},
            {"four",4},
            {"five",5},
            {"six",6},
            {"seven",7},
            {"eight",8},
            {"nine",9},
            {"ten",10},
            {"king",10},
            {"queen",10},
            {"jack",10},
            {"ace",0},
        };
        
    }
}