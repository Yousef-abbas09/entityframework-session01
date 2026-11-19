using System;
using System.Collections.Generic;
using System.Text;
using EfCore_assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCore_assignment.Data
{
    internal class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=ReadMoreBooksDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}