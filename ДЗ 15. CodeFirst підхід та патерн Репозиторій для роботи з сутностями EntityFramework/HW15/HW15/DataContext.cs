using HW15.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=UACHA1NB258\\SQLEXPRESS;Initial Catalog=HW15;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Good> Goods { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<StoreChain> StoreChains { get; set; }
        public DbSet<ShopGood> ShopGood { get; set; }
        public DbSet<StoreChainShop> StoreChainShop { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Shop-Good
            modelBuilder.Entity<ShopGood>()
                .HasKey(sg => new { sg.ShopId, sg.GoodId });

            modelBuilder.Entity<ShopGood>()
                .HasOne(s => s.Shop)
                .WithMany(sg => sg.GoodsInShop)
                .HasForeignKey(s => s.ShopId);

            modelBuilder.Entity<ShopGood>()
                .HasOne(g => g.Good)
                .WithMany(sg => sg.PlacedInShops)
                .HasForeignKey(g => g.GoodId);

            //StoreChain - Shop
            modelBuilder.Entity<StoreChainShop>()
                .HasKey(ss => new { ss.ShopId, ss.StoreChainId });

            modelBuilder.Entity<StoreChainShop>()
                .HasOne(sc => sc.StoreChain)
                .WithMany(ss => ss.ShopsInStoreChain)
                .HasForeignKey(sc => sc.StoreChainId);

            modelBuilder.Entity<StoreChainShop>()
                .HasOne(s => s.Shop)
                .WithMany(ss => ss.InStoreChains)
                .HasForeignKey(s => s.ShopId);

        }

    }
}
