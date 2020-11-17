using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using honeypot.shared.Models;
using Refit;

namespace honeypot.data.shared.Refit
{
    interface IUsers
    {
        [Get("/Users")]
        Task<IEnumerable<User>> Get();
    }
}
