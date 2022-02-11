﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Payspace2.Data;

namespace Payspace2.Migrations
{
    [DbContext(typeof(PlayspaceContext))]
    [Migration("20220211203759_akoEtwaSkacham")]
    partial class akoEtwaSkacham
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Payspace2.Data.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Payspace2.Data.Models.CartProducts", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CartId");

                    b.HasIndex("CartId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Payspace2.Data.Models.CoverImage", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique()
                        .HasFilter("[ProductId] IS NOT NULL");

                    b.ToTable("CoverImages");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("CoverImageId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Payspace2.Data.Models.ProductTags", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Payspace2.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Cart", b =>
                {
                    b.HasOne("Payspace2.Data.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("Payspace2.Data.Models.Cart", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Payspace2.Data.Models.CartProducts", b =>
                {
                    b.HasOne("Payspace2.Data.Models.Cart", "Cart")
                        .WithMany("Products")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Payspace2.Data.Models.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Payspace2.Data.Models.CoverImage", b =>
                {
                    b.HasOne("Payspace2.Data.Models.Product", "Product")
                        .WithOne("CoverImage")
                        .HasForeignKey("Payspace2.Data.Models.CoverImage", "ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Image", b =>
                {
                    b.HasOne("Payspace2.Data.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Product", b =>
                {
                    b.HasOne("Payspace2.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Payspace2.Data.Models.Company", "Company")
                        .WithMany("Products")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Payspace2.Data.Models.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerId");

                    b.HasOne("Payspace2.Data.Models.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("Company");

                    b.Navigation("Manufacturer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Payspace2.Data.Models.ProductTags", b =>
                {
                    b.HasOne("Payspace2.Data.Models.Product", "Product")
                        .WithMany("Tags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Payspace2.Data.Models.Tag", "Tag")
                        .WithMany("Products")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Cart", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Company", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Manufacturer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("CoverImage");

                    b.Navigation("Images");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("Payspace2.Data.Models.Tag", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Payspace2.Data.Models.User", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
