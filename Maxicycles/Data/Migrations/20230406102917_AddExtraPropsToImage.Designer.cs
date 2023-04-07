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
    [Migration("20230406102917_AddExtraPropsToImage")]
    partial class AddExtraPropsToImage
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

                    b.Property<string>("AltText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageName")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UploadedAt")
                        .HasColumnType("timestamp with time zone");

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
                            Id = "41a63bec-c878-48ea-b066-0883e9b97282",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "cd6b2b5f-7aac-4075-a76f-b1a5425b3f24",
                            Name = "StockControl",
                            NormalizedName = "STOCKCONTROL"
                        },
                        new
                        {
                            Id = "ff6776ea-0ea6-4dc7-a3f5-a9f97b313ca6",
                            Name = "Technician",
                            NormalizedName = "TECHNICIAN"
                        },
                        new
                        {
                            Id = "b187a4d5-dd38-4b93-a360-0f747fd213e1",
                            Name = "AccountsClerk",
                            NormalizedName = "ACCOUNTSCLERK"
                        },
                        new
                        {
                            Id = "1296f008-90f2-4787-ab04-99fe8b8686d5",
                            Name = "MediaManager",
                            NormalizedName = "MEDIAMANAGER"
                        },
                        new
                        {
                            Id = "10ce1258-4caa-4f60-9e38-85e2caf23a94",
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
                            UserId = "fedc7aca-315e-4ecc-8160-9ff5fd74d521",
                            RoleId = "41a63bec-c878-48ea-b066-0883e9b97282"
                        },
                        new
                        {
                            UserId = "02160236-144e-442e-b314-ede77517bb74",
                            RoleId = "cd6b2b5f-7aac-4075-a76f-b1a5425b3f24"
                        },
                        new
                        {
                            UserId = "72d34135-c719-4a1d-8165-541d20e33f5b",
                            RoleId = "ff6776ea-0ea6-4dc7-a3f5-a9f97b313ca6"
                        },
                        new
                        {
                            UserId = "36200392-931d-4557-bed5-7afd964746ab",
                            RoleId = "b187a4d5-dd38-4b93-a360-0f747fd213e1"
                        },
                        new
                        {
                            UserId = "e8ba216a-403b-4784-a8f5-2b80a3282ca4",
                            RoleId = "1296f008-90f2-4787-ab04-99fe8b8686d5"
                        },
                        new
                        {
                            UserId = "0e8817da-a6e7-42b2-8262-29ca3c18ce4b",
                            RoleId = "10ce1258-4caa-4f60-9e38-85e2caf23a94"
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
                            Id = "fedc7aca-315e-4ecc-8160-9ff5fd74d521",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "043fe3f5-65ce-40fd-9b10-72d2652b9ae1",
                            Email = "customer@example.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "CUSTOMER@EXAMPLE.CO.UK",
                            NormalizedUserName = "CUSTOMER@EXAMPLE.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEKRl2eJ3YuvdSMKAZD9f3D6lQ7Nhi09b4PHNyv5g8vgkzUyOCubmCUYQD9S2M/X2ig==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "fc176d87-fa50-4082-9e8c-ffbcf1b355df",
                            TwoFactorEnabled = false,
                            UserName = "customer@example.co.uk"
                        },
                        new
                        {
                            Id = "02160236-144e-442e-b314-ede77517bb74",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6d605e65-81ac-40d5-a63a-e5b4481eca0b",
                            Email = "stockControl@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "STOCKCONTROL@MAXICYCLES.CO.UK",
                            NormalizedUserName = "STOCKCONTROL@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEEr/u34UYZI2K63Ln2zR1ajI+gH7SGsOxnlM7MOb1vdcJbyYUlZtIEppesbDoDUQJA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "5820b5d4-f3e2-4ccd-8513-a9d439986197",
                            TwoFactorEnabled = false,
                            UserName = "stockControl@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "72d34135-c719-4a1d-8165-541d20e33f5b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a93a0b37-ff8a-48da-902f-515d82bf5de1",
                            Email = "technician@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TECHNICIAN@MAXICYCLES.CO.UK",
                            NormalizedUserName = "TECHNICIAN@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEACR+J2g0/q5JMQhxMg6yLauyZ2ZC9iLK7O6iY7UNaUM3WjCDuj9sVvMK90hyLL/0g==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "a3072e4e-e05f-42bf-b602-ccb036c8a6e8",
                            TwoFactorEnabled = false,
                            UserName = "technician@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "36200392-931d-4557-bed5-7afd964746ab",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ef6ee20e-17ac-45d7-8b02-86aac8e95e66",
                            Email = "accountsClerk@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                            NormalizedUserName = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAELGWXkhd+sLGgHSWQ/wU5SE6UoQ11ITwcsDN0dDqytGlHHTNYuedyhovaB6n6btKfw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "9bc2705a-77c7-4ac9-b305-65b704c90ed9",
                            TwoFactorEnabled = false,
                            UserName = "accountsClerk@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "e8ba216a-403b-4784-a8f5-2b80a3282ca4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "500d4fb8-94b9-4790-8b8e-d5c8448f7eee",
                            Email = "mediaManager@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                            NormalizedUserName = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEEsRdFdT9TqFhwBcLvPG4pJfbADd+CAOgzhk0Aps3pS2DNvZyVWbbudMT0bCzLnXcg==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "74364f02-ef30-43b9-88d6-fffac0bc54b2",
                            TwoFactorEnabled = false,
                            UserName = "mediaManager@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "0e8817da-a6e7-42b2-8262-29ca3c18ce4b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e7bf6a7e-21b1-4261-8720-bdc610ff5917",
                            Email = "manager@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "MANAGER@MAXICYCLES.CO.UK",
                            NormalizedUserName = "MANAGER@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEAEuzIWyXfh1UY0u2UB1QeBvzc5yCv5erfBNROSaxPwygyTJ+d0tIPgqUoCP4MxJ4w==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "f5dd2e92-a6c3-41c6-a36e-97641c1cdfed",
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