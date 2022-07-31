using System.Text;
using System.Security.Cryptography;
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.AspNetCore.Mvc;
using API.Entities;

namespace API.DTO
{
    public class RegisterDto
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public string BirthDate { get; set; }
        public string Tell { get; set; }
    }
}
