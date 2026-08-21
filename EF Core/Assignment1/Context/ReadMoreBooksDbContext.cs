using Microsoft.EntityFrameworkCore;
using System;
using EFCore1.Entities;
using System.Collections.Generic;
using System.Text;

namespace EFCore1.Context
{
    internal class ReadMoreBooksDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=. ; Database = ReadMoreBooksDB ; Trusted_Connection = true; TrustServerCertificate = true");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
