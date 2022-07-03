using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SalesManagmentSystem2.DAL.Models;
namespace SalesManagmentSystem2.DAL.DbInventory
{
    public  class InventoryDB:DbContext
    {
        public InventoryDB() : base("name=InventoryMS") 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<InventoryDB, Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuyProcessProduct>()
                .HasKey(BPP => new { BPP.Id_bp, BPP.Id_p});
            modelBuilder.Entity<OrderDetails>()
                .HasKey(OD => new { OD.Id_o,OD.Id_pp});
            // modelBuilder.Types().Configure(t => t.MapToStoredProcedures());
            // modelBuilder.Entity<BuyProcess>()
            // .HasOptional<Supplier>(s => s.Supplier)
            // .WithMany()
            // .WillCascadeOnDelete(false);

            // modelBuilder.Entity<BuyProcess>()
            //.HasOptional<User>(s => s.User)
            //.WithMany()
            //.WillCascadeOnDelete(false);

            modelBuilder.Entity<BuyProcess>()
           .HasOptional(c => c.Supplier)
           .WithMany(a => a.BuyProcesses)
           .HasForeignKey(c => c.SupplierId)
           .WillCascadeOnDelete(true);

            modelBuilder.Entity<BuyProcess>()
          .HasOptional(c => c.User)
          .WithMany(a => a.BuyProcesses)
          .HasForeignKey(c => c.UserId)
          .WillCascadeOnDelete(true);

            modelBuilder.Entity<Order>()
           .HasOptional(c => c.Customer)
           .WithMany(a => a.Orders)
           .HasForeignKey(c => c.customerId)
           .WillCascadeOnDelete(true);

            modelBuilder.Entity<Order>()
          .HasOptional(c => c.User)
          .WithMany(a => a.Orders)
          .HasForeignKey(c => c.userId)
          .WillCascadeOnDelete(true);

          //  modelBuilder.Entity<BuyProcessProduct>()
          // .HasOptional(c => c.Product)
          // .WithMany(a => a.buyProcessProducts)
          // .HasForeignKey(c => c.Id_bp)
          // .WillCascadeOnDelete(false);

          //  modelBuilder.Entity<BuyProcessProduct>()
          //.HasOptional(c => c.BuyProcess)
          //.WithMany(a => a.BuyProcessProducts)
          //.HasForeignKey(c => c.Id_bp)
          //.WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
         .HasOptional(c => c.Category)
         .WithMany(a => a.Products)
         .HasForeignKey(c => c.categoryId)
         .WillCascadeOnDelete(true);


          //  modelBuilder.Entity<OrderDetails>()
          // .HasOptional(c => c.Product)
          // .WithMany(a => a.OrderDetails)
          // .HasForeignKey(c => c.Id_pp)
          // .WillCascadeOnDelete(false);

          //  modelBuilder.Entity<OrderDetails>()
          //.HasOptional(c => c.Order)
          //.WithMany(a => a.OrderDetails)
          //.HasForeignKey(c => c.Id_o)
          //.WillCascadeOnDelete(false);



            base.OnModelCreating(modelBuilder);


        }
        public DbSet<User> Users { get; set; }
        public DbSet<BuyProcess> BuyProcesses { get; set; }
        public DbSet<BuyProcessProduct> BuyProcessProducts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }   
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
