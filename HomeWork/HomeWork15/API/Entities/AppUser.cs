using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace API.Entities
{
    public class AppUser
    {
     public int ID{get;set;}   
     public string Name{get;set;}   
     public byte[] PasswordHash{get;set;}
     public byte[] PasswordSalt{get;set;}
     public string Age { get; set; }
     public string Tell { get; set; }
    }
}