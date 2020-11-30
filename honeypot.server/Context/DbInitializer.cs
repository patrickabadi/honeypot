using honeypot.entities.shared.Contexts;
using honeypot.entities.shared.Enums;
using honeypot.entities.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace honeypot.server.Context
{
    public static class DbInitializer
    {
        public static void Initialize(UsersContext context)
        {
            context.Database.EnsureCreated();

            if(context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User{Username="pabadi", First="Patrick", Last="Abadi", Email="pabadi@pabadi.com", Type= UserType.Developer},
                new User{Username="dpackard", First="Daniel", Last="Packard", Email="dpackard@dpackard.com", Type= UserType.Administrator},
                new User{Username="msaulsberry", First="Mitchell", Last="Saulsberry", Email="msaulsberry@msaulsberry.com", Type= UserType.Developer},
                new User{Username="sryther", First="Sebastian", Last="Ryther", Email="sryther@sryther.com", Type= UserType.User},
                new User{Username="kcolden", First="Kyle", Last="Colden", Email="kcolden@kcolden.com", Type= UserType.NoUser},
            };
            foreach(var u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
        }
    }
}
