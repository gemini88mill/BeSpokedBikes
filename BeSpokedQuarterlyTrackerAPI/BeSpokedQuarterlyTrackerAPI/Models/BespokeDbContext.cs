using System;
using BeSpokedQuarterlyTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BeSpokedQuarterlyTrackerAPI
{
    public partial class BespokeDbContext : DbContext
    {
        public BespokeDbContext()
        {
        }

        public BespokeDbContext(DbContextOptions<BespokeDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:bespoke2021.database.windows.net,1433;Initial Catalog=Bespoke;Persist Security Info=False;User ID=rmiller;Password=3rtAsbF4pQWAtM5w;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            OnModelCreatingPartial(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<SalesPerson> SalesPersons { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
