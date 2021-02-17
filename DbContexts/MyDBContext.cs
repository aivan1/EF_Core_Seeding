using JustWorkForGodsSake.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustWorkForGodsSake.DbContexts
{
    public class MyDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> Groups { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<UserGroup>().ToTable("UserGroups");
            modelBuilder.Entity<User>().ToTable("Users");


            modelBuilder.Entity<User>().HasData
            (
                new User { Id = 1, HomeTown = "Varna", FirstName = "Jack", LastName = "Smith", UserGroupId = 1},
                new User { Id = 2, HomeTown = "Sofia", FirstName = "Simo", LastName = "Petrov", UserGroupId = 1 }
            );
            modelBuilder.Entity<UserGroup>().HasData
            (
                new UserGroup { Id = 1 , Name = "SoftServe", Memebers = 226 },
                new UserGroup { Id = 2, Name = "IKEA", Memebers = 150 }
            );
        }
    }
}
