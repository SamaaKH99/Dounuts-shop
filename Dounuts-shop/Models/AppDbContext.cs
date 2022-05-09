﻿using Dounuts_shop.Models;
using Microsoft.EntityFrameworkCore;

namespace Donuts_shop.Models
{
    // This will map to the actual database table in our database.
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // These DbSets will send a SQL queries that will read the data stored in our database.
        public DbSet<Donut> Donuts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
