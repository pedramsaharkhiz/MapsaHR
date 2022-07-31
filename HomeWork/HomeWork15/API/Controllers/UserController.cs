using System.Collections;
using System.Threading.Tasks.Dataflow;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using API.Data;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return _context.Users.ToList();
        }
         [HttpGet("{id}")]
        public ActionResult<AppUser> GetUserByID(int id)
        {
            return _context.Users.Find(id);
        }
    }
}
