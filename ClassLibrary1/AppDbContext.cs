using DemoApp.Repository.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace DemoApp.Repository
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<User> Users { get; set; }
    }


    
}
