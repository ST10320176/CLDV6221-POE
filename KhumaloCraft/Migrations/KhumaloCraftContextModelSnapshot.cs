﻿// <auto-generated />
using System;
using KhumaloCraft.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KhumaloCraft.Migrations
{
    [DbContext(typeof(KhumaloCraftContext))]
    partial class KhumaloCraftContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KhumaloCraft.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int?>("AmountItems")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("KhumaloCraft.Models.Order1", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID");

                    b.ToTable("Order1");
                });

            modelBuilder.Entity("KhumaloCraft.Models.Order_Product", b =>
                {
                    b.Property<int>("OrderProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderProductId"));

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Order1OrderID")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("availability")
                        .HasColumnType("bit");

                    b.HasKey("OrderProductId");

                    b.HasIndex("Order1OrderID");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Order_Product");
                });

            modelBuilder.Entity("KhumaloCraft.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("KhumaloCraft.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Cellnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("KhumaloCraft.Models.Order_Product", b =>
                {
                    b.HasOne("KhumaloCraft.Models.Order1", "Order1")
                        .WithMany("Order_Product")
                        .HasForeignKey("Order1OrderID");

                    b.HasOne("KhumaloCraft.Models.Order", "Order")
                        .WithMany("Order_Product")
                        .HasForeignKey("OrderId");

                    b.HasOne("KhumaloCraft.Models.Product", "Product")
                        .WithMany("Order_Product")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Order1");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("KhumaloCraft.Models.Order", b =>
                {
                    b.Navigation("Order_Product");
                });

            modelBuilder.Entity("KhumaloCraft.Models.Order1", b =>
                {
                    b.Navigation("Order_Product");
                });

            modelBuilder.Entity("KhumaloCraft.Models.Product", b =>
                {
                    b.Navigation("Order_Product");
                });
#pragma warning restore 612, 618
        }
    }
}
