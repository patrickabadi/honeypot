using honeypot.entities.shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace honeypot.entities.shared.Contexts
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(f => f.Id);
            //builder.HasMany(f => f.Items).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class ConnectionStringOptions
    {
        public string SqlConnectionString { get; set; }
    }

    public class UsersContext :
#if SERVER
    CrossSync.Infrastructure.Server.ServerContext
#else
    CrossSync.Infrastructure.Client.ClientContext
#endif
    {
#if SERVER
        private readonly IOptions<ConnectionStringOptions> options;
        public IConfiguration Configuration { get; }

        public UsersContext(IOptions<ConnectionStringOptions> options, IConfiguration configuration)
        {
            this.options = options;
            Configuration = configuration;
        }
#else
        private readonly string path;

        public TodoListContext() : this(@"c:\")
        {
        }

        public TodoListContext(string path)
        {
            this.path = path;
        }
#endif

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsersConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

#if SERVER
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
#else
            optionsBuilder.UseSqlite($"FileName={System.IO.Path.Combine(path, "data.db")}");
#endif
        }
    }
}
