﻿// <auto-generated />
using System;
using Maxicycles.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Maxicycles.Data.Migrations
{
    [DbContext(typeof(MaxicyclesDbContext))]
    partial class MaxicyclesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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
                            Id = "91e9e727-bd11-45ff-a743-bb7767780b71",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "b2dc4fed-4016-48ff-ac49-cf11b1c8c27e",
                            Name = "StockControl",
                            NormalizedName = "STOCKCONTROL"
                        },
                        new
                        {
                            Id = "b20d1672-a71d-4fbe-8e67-8d1607002866",
                            Name = "Technician",
                            NormalizedName = "TECHNICIAN"
                        },
                        new
                        {
                            Id = "d33ffb99-8e00-4ac9-ae63-e55f638146c8",
                            Name = "AccountsClerk",
                            NormalizedName = "ACCOUNTSCLERK"
                        },
                        new
                        {
                            Id = "e2c31d48-35ce-4ee6-b26a-1e79cfa64549",
                            Name = "MediaManager",
                            NormalizedName = "MEDIAMANAGER"
                        },
                        new
                        {
                            Id = "f6423f41-1702-44ad-bcb7-c06da436bd02",
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
                            UserId = "4f505b27-1e2c-4236-aed3-499051f806b7",
                            RoleId = "91e9e727-bd11-45ff-a743-bb7767780b71"
                        },
                        new
                        {
                            UserId = "97ff7bcb-8f73-4899-9697-0c35692a3ccb",
                            RoleId = "b2dc4fed-4016-48ff-ac49-cf11b1c8c27e"
                        },
                        new
                        {
                            UserId = "969aeccd-77a5-4158-98fd-362298815d7f",
                            RoleId = "b20d1672-a71d-4fbe-8e67-8d1607002866"
                        },
                        new
                        {
                            UserId = "4e87c5ae-7fea-4f44-ac7b-a894a03a9dcf",
                            RoleId = "d33ffb99-8e00-4ac9-ae63-e55f638146c8"
                        },
                        new
                        {
                            UserId = "588e6e14-da69-44fc-9eef-51f7af88f77e",
                            RoleId = "e2c31d48-35ce-4ee6-b26a-1e79cfa64549"
                        },
                        new
                        {
                            UserId = "4d684e06-c9fb-49d1-8608-182dc27142e5",
                            RoleId = "f6423f41-1702-44ad-bcb7-c06da436bd02"
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
                            Id = "4f505b27-1e2c-4236-aed3-499051f806b7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ed96f118-f730-4e04-8cc7-b06bed275a94",
                            Email = "customer@example.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "CUSTOMER@EXAMPLE.CO.UK",
                            NormalizedUserName = "CUSTOMER@EXAMPLE.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEN/0BDItfSE83ea1tz8Ud0jDcs+BLJSY1auoPsyTwO0jn21xFfHMuceRmW8j3huvhg==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "9bfe7987-07c5-4b11-8b53-2a55188269d1",
                            TwoFactorEnabled = false,
                            UserName = "customer@example.co.uk"
                        },
                        new
                        {
                            Id = "97ff7bcb-8f73-4899-9697-0c35692a3ccb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "774f1732-7707-4811-9372-9ef6af29e52e",
                            Email = "stockControl@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "STOCKCONTROL@MAXICYCLES.CO.UK",
                            NormalizedUserName = "STOCKCONTROL@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEC8BxZg+b75zaNAUeA/oyyuEyEsj0i/LBTJqhgeTYwD2vKi/xLv68bwvycIfZUwAlA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "a22e4d5d-feb0-4501-bc3f-f5b5cfc0338e",
                            TwoFactorEnabled = false,
                            UserName = "stockControl@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "969aeccd-77a5-4158-98fd-362298815d7f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8a75b0bb-e9f1-4a4d-b262-90b20c3b5444",
                            Email = "technician@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TECHNICIAN@MAXICYCLES.CO.UK",
                            NormalizedUserName = "TECHNICIAN@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEKO4hVlaLbH7LuVYbKw0BYefRITXxMCU8Kh56o13y95igmbgh7bes5ox/d6Ak7DzXg==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "f9578329-caa3-4c2c-8d7f-a0e795e7e248",
                            TwoFactorEnabled = false,
                            UserName = "technician@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "4e87c5ae-7fea-4f44-ac7b-a894a03a9dcf",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "09f899b2-fa95-40a2-be1f-514e2f53ac8d",
                            Email = "accountsClerk@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                            NormalizedUserName = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAENZPlQNg0Ueo0geazLLRVkhXhB75lIsgo5+NMAD5td/SzLSY3W3iNUaUyIv88EsOTA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "21f1cb1e-9824-425d-90a8-0ec32a5463ef",
                            TwoFactorEnabled = false,
                            UserName = "accountsClerk@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "588e6e14-da69-44fc-9eef-51f7af88f77e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "27a21972-89c0-4c3d-81ac-9d7266726b59",
                            Email = "mediaManager@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                            NormalizedUserName = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEPoPvgI9KYFI1AUooA2kNx4oOhqVQv7oE3oBnbr/rjMp37ew8BbsYOnLXaecBxfYag==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "73095fe1-72f1-4292-888f-bb927fed6d87",
                            TwoFactorEnabled = false,
                            UserName = "mediaManager@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "4d684e06-c9fb-49d1-8608-182dc27142e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f0c3624-99d5-4405-8edd-04a95e95da98",
                            Email = "manager@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "MANAGER@MAXICYCLES.CO.UK",
                            NormalizedUserName = "MANAGER@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEPxB+pfgfG7FxSXkJU4DkF/KifPXaX9bBCB9TIir73/8knmT+Q8IO0leH0NOVuGGwg==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "310c3cb4-dfbb-4c9d-a3a9-d9d7d023690f",
                            TwoFactorEnabled = false,
                            UserName = "manager@maxicycles.co.uk"
                        });
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
#pragma warning restore 612, 618
        }
    }
}
