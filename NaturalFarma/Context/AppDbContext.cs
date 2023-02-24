﻿using Microsoft.EntityFrameworkCore;
using NaturalFarma.Models;

namespace NaturalFarma.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }


    }
}
