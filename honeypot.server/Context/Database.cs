using honeypot.shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace honeypot.server.Context
{
    public class Database : DbContext
    {
        public DbSet<User> Users { get; set; }

        public Database(DbContextOptions<Database> options) : base(options) { }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                var b = entityEntry.Entity as EntityBase;
                if (b == null)
                    continue;

                b.UpdatedAt = DateTime.UtcNow;

                if (entityEntry.State == EntityState.Added)
                {
                    b.CreatedAt = DateTime.UtcNow;
                }
            }

            return base.SaveChanges();
        }
    }
}
