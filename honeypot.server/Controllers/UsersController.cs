using honeypot.server.Context;
using honeypot.entities.shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrossSync.AspNetCore.Api;
using CrossSync.Entity.Abstractions.Services;
using CrossSync.Entity.Abstractions.UnitOfWork;

namespace honeypot.server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : SyncController<User>
    {
        public UsersController(IUnitOfWork unitOfWork, ISyncRepository<User> repository) : base(unitOfWork, repository)
        {
        }

    }
}
