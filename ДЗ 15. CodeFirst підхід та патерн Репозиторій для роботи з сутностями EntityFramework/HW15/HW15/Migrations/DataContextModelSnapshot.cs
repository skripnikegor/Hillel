﻿// <auto-generated />
using HW15;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HW15.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HW15.Models.Good", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("HW15.Models.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("HW15.Models.ShopGood", b =>
                {
                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<int>("GoodId")
                        .HasColumnType("int");

                    b.HasKey("ShopId", "GoodId");

                    b.HasIndex("GoodId");

                    b.ToTable("ShopGood");
                });

            modelBuilder.Entity("HW15.Models.StoreChain", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("StoreChains");
                });

            modelBuilder.Entity("HW15.Models.StoreChainShop", b =>
                {
                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<int>("StoreChainId")
                        .HasColumnType("int");

                    b.HasKey("ShopId", "StoreChainId");

                    b.HasIndex("StoreChainId");

                    b.ToTable("StoreChainShop");
                });

            modelBuilder.Entity("HW15.Models.ShopGood", b =>
                {
                    b.HasOne("HW15.Models.Good", "Good")
                        .WithMany("PlacedInShops")
                        .HasForeignKey("GoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HW15.Models.Shop", "Shop")
                        .WithMany("GoodsInShop")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Good");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("HW15.Models.StoreChainShop", b =>
                {
                    b.HasOne("HW15.Models.Shop", "Shop")
                        .WithMany("InStoreChains")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HW15.Models.StoreChain", "StoreChain")
                        .WithMany("ShopsInStoreChain")
                        .HasForeignKey("StoreChainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");

                    b.Navigation("StoreChain");
                });

            modelBuilder.Entity("HW15.Models.Good", b =>
                {
                    b.Navigation("PlacedInShops");
                });

            modelBuilder.Entity("HW15.Models.Shop", b =>
                {
                    b.Navigation("GoodsInShop");

                    b.Navigation("InStoreChains");
                });

            modelBuilder.Entity("HW15.Models.StoreChain", b =>
                {
                    b.Navigation("ShopsInStoreChain");
                });
#pragma warning restore 612, 618
        }
    }
}
