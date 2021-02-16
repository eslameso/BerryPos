using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Pos.Models
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUsers>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Branches> Branches { get; set; }
        public DbSet<BranchesProducts> BranchesProducts { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Measurments> Measurments { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductsMeasurments> ProductsMeasurments { get; set; }
        public DbSet<ProductsStore> ProductsStore { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoice { get; set; }
        public DbSet<SaleInvoices> SaleInvoices { get; set; }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);
    modelBuilder.Entity<BranchesProducts>()
        .HasKey(c => new { c.ProductId, c.BranchId });

    modelBuilder.Entity<ProductsMeasurments>()
        .HasKey(x=> new {x.ProductId,x.MeasurmentId});

    modelBuilder.Entity<ProductsStore>()
        .HasKey(c => new { c.ProductId, c.SoreId });

    modelBuilder.Entity<BranchesProducts>()
        .HasKey(c => new { c.ProductId, c.BranchId });

    modelBuilder.Entity<PurchaseInvoice>()
        .HasKey(c => new { c.Id, c.ProductId,c.SupplierId });
        
    modelBuilder.Entity<SaleInvoices>()
    .HasKey(x => new {x.Id,x.ProductId,x.ClientID});

}
        
    }
}