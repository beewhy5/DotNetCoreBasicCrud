﻿using Microsoft.EntityFrameworkCore;

namespace CoreBasicCrudApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers {get; set;}
    }
}