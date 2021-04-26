﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pos.Models;

namespace Pos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210426134713_BranchUserRef")]
    partial class BranchUserRef
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Pos.Models.ApplicationUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<int?>("BranchesProductsBranchId")
                        .HasColumnType("int");

                    b.Property<int?>("BranchesProductsProductId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("JobtitleId")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OthrMobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relegion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("JobtitleId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("BranchesProductsProductId", "BranchesProductsBranchId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Pos.Models.Branches", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameA")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Pos.Models.BranchesProducts", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "BranchId");

                    b.HasIndex("BranchId");

                    b.ToTable("BranchesProducts");
                });

            modelBuilder.Entity("Pos.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Pos.Models.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OthrMobileNumber")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Pos.Models.JobTitles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobTitles");
                });

            modelBuilder.Entity("Pos.Models.Measurments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MeasurmentType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameA")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Measurments");
                });

            modelBuilder.Entity("Pos.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Cell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Coulmn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Rack")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Pos.Models.ProductsMeasurments", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("MeasurmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId", "MeasurmentId");

                    b.HasIndex("MeasurmentId");

                    b.ToTable("ProductsMeasurments");
                });

            modelBuilder.Entity("Pos.Models.ProductsStore", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SoreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Salesprice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("purchaseprice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "SoreId");

                    b.HasIndex("SoreId");

                    b.ToTable("ProductsStore");
                });

            modelBuilder.Entity("Pos.Models.PurchaseInvoice", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("AppUserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PurchaseDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("Id", "ProductId", "SupplierId");

                    b.HasIndex("AppUserID");

                    b.HasIndex("BranchId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.HasIndex("SupplierId");

                    b.ToTable("PurchaseInvoice");
                });

            modelBuilder.Entity("Pos.Models.SaleInvoices", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("AppUserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("SaleDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("Id", "ProductId", "ClientID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("BranchId");

                    b.HasIndex("ClientID");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("SaleInvoices");
                });

            modelBuilder.Entity("Pos.Models.Stores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("Pos.Models.Suppliers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OthrMobileNumber")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Pos.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Pos.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pos.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Pos.Models.ApplicationUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pos.Models.ApplicationUsers", b =>
                {
                    b.HasOne("Pos.Models.Branches", "Branches")
                        .WithMany("Users")
                        .HasForeignKey("BranchId");

                    b.HasOne("Pos.Models.JobTitles", "jobTitles")
                        .WithMany("Users")
                        .HasForeignKey("JobtitleId");

                    b.HasOne("Pos.Models.BranchesProducts", null)
                        .WithMany("Users")
                        .HasForeignKey("BranchesProductsProductId", "BranchesProductsBranchId");

                    b.Navigation("Branches");

                    b.Navigation("jobTitles");
                });

            modelBuilder.Entity("Pos.Models.BranchesProducts", b =>
                {
                    b.HasOne("Pos.Models.Branches", "Branches")
                        .WithMany("BranchesProducts")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pos.Models.Products", "Products")
                        .WithMany("BranchesProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branches");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Pos.Models.Category", b =>
                {
                    b.HasOne("Pos.Models.Category", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Pos.Models.Products", b =>
                {
                    b.HasOne("Pos.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Pos.Models.ProductsMeasurments", b =>
                {
                    b.HasOne("Pos.Models.Measurments", "Measurments")
                        .WithMany("ProductsMeasurments")
                        .HasForeignKey("MeasurmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pos.Models.Products", "Products")
                        .WithMany("ProductsMeasurments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Measurments");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Pos.Models.ProductsStore", b =>
                {
                    b.HasOne("Pos.Models.Products", "Product")
                        .WithMany("ProductsStore")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pos.Models.Stores", "Store")
                        .WithMany("ProductsStore")
                        .HasForeignKey("SoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Pos.Models.PurchaseInvoice", b =>
                {
                    b.HasOne("Pos.Models.ApplicationUsers", "ApplicationUsers")
                        .WithMany("PurchaseInvoices")
                        .HasForeignKey("AppUserID");

                    b.HasOne("Pos.Models.Branches", "Branches")
                        .WithMany("PurchaseInvoices")
                        .HasForeignKey("BranchId");

                    b.HasOne("Pos.Models.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pos.Models.Stores", "Stores")
                        .WithMany("PurchaseInvoices")
                        .HasForeignKey("StoreId");

                    b.HasOne("Pos.Models.Suppliers", "Suppliers")
                        .WithMany("PurchaseInvoices")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUsers");

                    b.Navigation("Branches");

                    b.Navigation("Products");

                    b.Navigation("Stores");

                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("Pos.Models.SaleInvoices", b =>
                {
                    b.HasOne("Pos.Models.ApplicationUsers", "ApplicationUsers")
                        .WithMany("SaleInvoices")
                        .HasForeignKey("AppUserID");

                    b.HasOne("Pos.Models.Branches", "Branches")
                        .WithMany("SaleInvoices")
                        .HasForeignKey("BranchId");

                    b.HasOne("Pos.Models.Clients", "Clients")
                        .WithMany("SaleInvoices")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pos.Models.Products", "Products")
                        .WithMany("SaleInvoices")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pos.Models.Stores", "Stores")
                        .WithMany("SaleInvoices")
                        .HasForeignKey("StoreId");

                    b.Navigation("ApplicationUsers");

                    b.Navigation("Branches");

                    b.Navigation("Clients");

                    b.Navigation("Products");

                    b.Navigation("Stores");
                });

            modelBuilder.Entity("Pos.Models.ApplicationUsers", b =>
                {
                    b.Navigation("PurchaseInvoices");

                    b.Navigation("SaleInvoices");
                });

            modelBuilder.Entity("Pos.Models.Branches", b =>
                {
                    b.Navigation("BranchesProducts");

                    b.Navigation("PurchaseInvoices");

                    b.Navigation("SaleInvoices");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Pos.Models.BranchesProducts", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Pos.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Pos.Models.Clients", b =>
                {
                    b.Navigation("SaleInvoices");
                });

            modelBuilder.Entity("Pos.Models.JobTitles", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Pos.Models.Measurments", b =>
                {
                    b.Navigation("ProductsMeasurments");
                });

            modelBuilder.Entity("Pos.Models.Products", b =>
                {
                    b.Navigation("BranchesProducts");

                    b.Navigation("ProductsMeasurments");

                    b.Navigation("ProductsStore");

                    b.Navigation("SaleInvoices");
                });

            modelBuilder.Entity("Pos.Models.Stores", b =>
                {
                    b.Navigation("ProductsStore");

                    b.Navigation("PurchaseInvoices");

                    b.Navigation("SaleInvoices");
                });

            modelBuilder.Entity("Pos.Models.Suppliers", b =>
                {
                    b.Navigation("PurchaseInvoices");
                });
#pragma warning restore 612, 618
        }
    }
}
