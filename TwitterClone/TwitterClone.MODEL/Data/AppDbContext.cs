using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.MODEL.Entities;

namespace TwitterClone.MODEL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            //DefaultData();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Twit> Twits { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public void DefaultData()
        {
            var user = new User
            {
                Name = "Test",
                LastName = "Admin1",
                Username = "TA1",
                Password = "123",
                Birthday = DateTime.Now.AddYears(-25),
                ImageUrl = "No Image",
                IsAdmin = true,
            };
            Users.Add(user);
            user = new User
            {
                Name = "Test",
                LastName = "Admin2",
                Username = "TA2",
                Password = "123",
                Birthday = DateTime.Now.AddYears(-25),
                ImageUrl = "No Image",
                IsAdmin = true,
            };
            Users.Add(user);
        }
    }
}
