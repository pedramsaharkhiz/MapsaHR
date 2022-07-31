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
using API.DTO;

namespace API.Controllers
{
    public class AccountController : BaseController
    {
        public DataContext _context { get; set; }

        public AccountController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AppUser>> PostRegister(RegisterDto RDto)
        {
            var e = RDto.BirthDate.Replace("/", string.Empty);
            var Y = await CalYear(e);
            //
            if (await IsExist(RDto.UserName))
                return BadRequest("Already Exist !");
            //
            if (Y[0] < 18)
                return BadRequest("Not Permitted!");
            //
            if (!await CheckTell(RDto.Tell))
                return BadRequest("Invalid TellNumber!");
            //
            using var hmac = new HMACSHA512();
            var _age = Y[0].ToString() + "/" + Y[1].ToString() + "/" + Y[2].ToString();
            var user = new AppUser
            {
                Age = _age,
                Name = RDto.UserName,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(RDto.PassWord)),
                PasswordSalt = hmac.Key,
                Tell = RDto.Tell
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> IsExist(string UserName)
        {
            return await _context.Users.AnyAsync(c => c.Name == UserName);
        }

        public async Task<int[]> CalYear(string Y)
        {
            int _year = Convert.ToInt32(Y.Substring(0, 4));
            int _month = Convert.ToInt32(Y.Substring(4, 2));
            int _day = Convert.ToInt32(Y.Substring(6, 2));
            DateTime Now = DateTime.Now;
            int year = Now.Year - _year;
            int Tot_birth = _month * 30 + _day;
            int Tot_now = Now.Month * 30 + Now.Day;
            int Tot_age;
            if (Tot_now < Tot_birth)
            {
                year--;
                Tot_age = 360 - Tot_birth + Tot_now;
            }
            else
            {
                Tot_age = Tot_now - Tot_birth;
            }
            int month = Tot_age / 30;
            int day = Tot_age - month * 30;
            return new int[] { year, month, day };
        }

        public async Task<bool> CheckTell(string N)
        {
            int t;
            if (int.TryParse(N, out t) && N.Length == 8)
            {
                return true;
            }
            else
                return false;
        }
    }
}
