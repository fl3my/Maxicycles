﻿// <auto-generated />
using System;
using Maxicycles.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Maxicycles.Data.Migrations
{
    [DbContext(typeof(MaxicyclesDbContext))]
    [Migration("20230406095617_AddImageTable")]
    partial class AddImageTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Maxicycles.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Maxicycles.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageName")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Maxicycles.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("ImageId")
                        .HasColumnType("integer");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Maxicycles.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ac64637f-9f3c-4a6d-8a5b-0b7d28301f64",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "3eb4ec0e-0c5d-4e0f-8e2f-626ba8c4663c",
                            Name = "StockControl",
                            NormalizedName = "STOCKCONTROL"
                        },
                        new
                        {
                            Id = "2ff65788-989b-4e79-b635-d65e64b3ec1a",
                            Name = "Technician",
                            NormalizedName = "TECHNICIAN"
                        },
                        new
                        {
                            Id = "0d1f3fa0-c484-4da4-9284-55256eb80ce0",
                            Name = "AccountsClerk",
                            NormalizedName = "ACCOUNTSCLERK"
                        },
                        new
                        {
                            Id = "3c3f1915-4242-4da9-9d04-a44985c9df4b",
                            Name = "MediaManager",
                            NormalizedName = "MEDIAMANAGER"
                        },
                        new
                        {
                            Id = "08705297-472b-4d99-bc95-03acfb58eb20",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1d90e1dc-3619-4938-ba37-4ecbe054bf90",
                            RoleId = "ac64637f-9f3c-4a6d-8a5b-0b7d28301f64"
                        },
                        new
                        {
                            UserId = "801fd803-b4c9-4363-9ee2-a6e412766a03",
                            RoleId = "3eb4ec0e-0c5d-4e0f-8e2f-626ba8c4663c"
                        },
                        new
                        {
                            UserId = "d4045d95-de15-41af-a46a-7a4ec1eabe8a",
                            RoleId = "2ff65788-989b-4e79-b635-d65e64b3ec1a"
                        },
                        new
                        {
                            UserId = "3c51fe3e-0eba-4b67-99d3-571198ae6f7c",
                            RoleId = "0d1f3fa0-c484-4da4-9284-55256eb80ce0"
                        },
                        new
                        {
                            UserId = "c997fd07-20de-4c95-b5e2-cbb6e60d4caf",
                            RoleId = "3c3f1915-4242-4da9-9d04-a44985c9df4b"
                        },
                        new
                        {
                            UserId = "b030a19d-6df6-4d8f-b163-651a6d7009e5",
                            RoleId = "08705297-472b-4d99-bc95-03acfb58eb20"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Maxicycles.Models.MaxicyclesUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("text");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Postcode")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("MaxicyclesUser");

                    b.HasData(
                        new
                        {
                            Id = "1d90e1dc-3619-4938-ba37-4ecbe054bf90",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6716f349-81b7-45b6-870d-ab17c3d0c9d4",
                            Email = "customer@example.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "CUSTOMER@EXAMPLE.CO.UK",
                            NormalizedUserName = "CUSTOMER@EXAMPLE.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAED4aLPguCBA0AYLH3r36Kl9gfHa8JAIOh4hw7uqfCjL8CaVcBsFQi5Knea0UjA8wEg==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "6b7c502d-899a-40ae-bd9e-853af671bd52",
                            TwoFactorEnabled = false,
                            UserName = "customer@example.co.uk"
                        },
                        new
                        {
                            Id = "801fd803-b4c9-4363-9ee2-a6e412766a03",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6d9dd256-ff88-45f5-a152-a30a98222aac",
                            Email = "stockControl@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "STOCKCONTROL@MAXICYCLES.CO.UK",
                            NormalizedUserName = "STOCKCONTROL@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEK4G7FMU+j4NwDic2YGDCiL2Sef/6V1xljhZjNxyZrHwHU7BNiwGquOn3rxDtC0CwQ==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "535dbd53-f442-4b48-9acc-6381684fbb98",
                            TwoFactorEnabled = false,
                            UserName = "stockControl@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "d4045d95-de15-41af-a46a-7a4ec1eabe8a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fe653818-a291-42f2-a016-c01b5ea9ca34",
                            Email = "technician@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TECHNICIAN@MAXICYCLES.CO.UK",
                            NormalizedUserName = "TECHNICIAN@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEHhq9PX28erWNeKPgs287kxxHK8Hq6SESgf4QYbg4BXOAmG0pEC6ljWZzj71kXHZXA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "10c02244-5794-44a3-955c-9154846c9147",
                            TwoFactorEnabled = false,
                            UserName = "technician@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "3c51fe3e-0eba-4b67-99d3-571198ae6f7c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e1f9a8bc-51b2-41f8-83e1-a85d484553fd",
                            Email = "accountsClerk@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                            NormalizedUserName = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEDUCZ3LoKEC9TyZmvIkiqk/HAQF9P9gbjP29loDoJVGaXBWhKRiGAGVbS3ZKpY02Qw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "40860fb3-e0eb-45c3-89bd-b5e0a13da461",
                            TwoFactorEnabled = false,
                            UserName = "accountsClerk@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "c997fd07-20de-4c95-b5e2-cbb6e60d4caf",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0039db32-be3c-41f9-a175-19d0d86784be",
                            Email = "mediaManager@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                            NormalizedUserName = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEDgmXf/xpGNUn+X7QCJQInbXJS/ce9sqT/gO2Mdr66dgX7DlaWTJE5G7sTrGy6gtTw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "2ed5c784-a2b2-4900-b3fa-4797f6e04133",
                            TwoFactorEnabled = false,
                            UserName = "mediaManager@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "b030a19d-6df6-4d8f-b163-651a6d7009e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9689c6a1-363c-4276-bad0-634341c31adc",
                            Email = "manager@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "MANAGER@MAXICYCLES.CO.UK",
                            NormalizedUserName = "MANAGER@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEESRGoltjB36IbMWpCG/o3Q8CJkyAh8IOMAifJ6sUjWqA/ToCmVTLhPM8lbKX+roXA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "1b7de680-16bd-4544-9d62-65c6b69e73e2",
                            TwoFactorEnabled = false,
                            UserName = "manager@maxicycles.co.uk"
                        });
                });

            modelBuilder.Entity("Maxicycles.Models.Product", b =>
                {
                    b.HasOne("Maxicycles.Models.Image", "Image")
                        .WithMany("Products")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maxicycles.Models.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Maxicycles.Models.SubCategory", b =>
                {
                    b.HasOne("Maxicycles.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Maxicycles.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Maxicycles.Models.Image", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Maxicycles.Models.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
