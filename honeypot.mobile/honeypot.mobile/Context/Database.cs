using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using honeypot.shared.Models;
using Microsoft.EntityFrameworkCore;
using Xamarin.Essentials;

namespace honeypot.mobile.Context
{
    public class Database: DbContext
    {
        public DbSet<User> Users { get; set; }

        public Database()
        {
            SQLitePCL.Batteries_V2.Init();

            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "honeypot.db3");

            optionsBuilder
                .UseSqlite($"Filename={dbPath}");
        }
    }
}
