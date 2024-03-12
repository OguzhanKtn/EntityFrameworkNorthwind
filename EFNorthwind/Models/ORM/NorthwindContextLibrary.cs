using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNorthwind.Models.ORM
{
    public class NorthwindContextLibrary:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-F2RDBLP\SQLEXPRESS;Database=NorthwindDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
