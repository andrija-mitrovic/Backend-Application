﻿// <auto-generated />
using Innoloft.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Innoloft.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Innoloft.Core.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<int>("GeoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.Property<string>("Suite")
                        .HasColumnType("TEXT");

                    b.Property<string>("Zipcode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GeoId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Innoloft.Core.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bs")
                        .HasColumnType("TEXT");

                    b.Property<string>("CatchPhrase")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Innoloft.Core.Models.Geo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lat")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lng")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Geos");
                });

            modelBuilder.Entity("Innoloft.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Innoloft.Core.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("Innoloft.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddressId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("Website")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Innoloft.Core.Models.Address", b =>
                {
                    b.HasOne("Innoloft.Core.Models.Geo", "Geo")
                        .WithMany()
                        .HasForeignKey("GeoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Innoloft.Core.Models.Product", b =>
                {
                    b.HasOne("Innoloft.Core.Models.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Innoloft.Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Innoloft.Core.Models.User", b =>
                {
                    b.HasOne("Innoloft.Core.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Innoloft.Core.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
