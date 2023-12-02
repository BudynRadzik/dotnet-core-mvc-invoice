using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Infrastructure.Persistence
{
    public class InvoiceDbContext : DbContext
    {
        public DbSet<Domain.Entities.Invoice> Invoices { get; set; }
        public DbSet<Domain.Entities.Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=InvoiceDb;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Company>()
                .OwnsOne(c => c.ContactDetails);
        }
        
    }
}
