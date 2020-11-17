using honeypot.data.shared.Enums;
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
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new List<User>
            {
                new User
                {
                    Username = "User1",
                    First = "First",
                    Last = "Last",
                    Email = "user@user.com",
                    Type = UserType.Administrator,
                },
                new User
                {
                    Username = "User2",
                    First = "First",
                    Last = "Last",
                    Email = "user@user.com",
                    Type = UserType.Developer,
                },
                new User
                {
                    Username = "User3",
                    First = "First",
                    Last = "Last",
                    Email = "user@user.com",
                    Type = UserType.NoUser,
                }
            };
        }
    }
}
