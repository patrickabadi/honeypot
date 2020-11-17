using honeypot.shared.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace honeypot.data.shared.Refit
{
    public static class UsersService
    {
        private const string _apiUrl = "https://localhost:44325/";

        static public async Task<IEnumerable<User>> Get()
        {
            var api = RestService.For<IUsers>(_apiUrl);

            return await api.Get();
        }
    }
}
