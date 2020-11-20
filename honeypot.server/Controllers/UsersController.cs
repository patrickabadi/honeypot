using honeypot.data.shared.Enums;
using honeypot.server.Context;
using honeypot.shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace honeypot.server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly Database _context;

        public UsersController(Database context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.Users.ToList();
        }
    }
}
