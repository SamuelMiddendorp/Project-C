using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDb.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        //public DbSet<Atribute> Atributes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //here we define the name of our database
            optionsBuilder.UseMySql("User ID=root;Password=Therichlife1;Host=localhost;Port=3306;Database=ProductDB;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
