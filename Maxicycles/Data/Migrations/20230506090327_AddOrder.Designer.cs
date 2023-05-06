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
    [Migration("20230506090327_AddOrder")]
    partial class AddOrder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Maxicycles.Models.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<string>("MaxicyclesUserId")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("MaxicyclesUserId");

                    b.ToTable("BasketItem");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BasketItem");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Maxicycles.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Maxicycles.Models.DeliveryMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MinDaysToDeliver")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DeliveryMethods");
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

            modelBuilder.Entity("Maxicycles.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ImageId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Item");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Item");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Maxicycles.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DeliveryMethodId")
                        .HasColumnType("integer");

                    b.Property<string>("MaxicyclesUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryMethodId");

                    b.HasIndex("MaxicyclesUserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Maxicycles.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");

                    b.HasDiscriminator<string>("Discriminator").HasValue("OrderItem");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Maxicycles.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("boolean");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Payment");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Payment");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Maxicycles.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
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
                            Id = "75e8f28e-b7aa-48b5-8d41-5329c613ea4b",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "a26009ae-cbd6-409b-b0b7-6ac8452b4702",
                            Name = "StockControl",
                            NormalizedName = "STOCKCONTROL"
                        },
                        new
                        {
                            Id = "b7a3af63-7fa2-421d-88ab-5e7d603599a5",
                            Name = "Technician",
                            NormalizedName = "TECHNICIAN"
                        },
                        new
                        {
                            Id = "bc800078-c380-49ec-ae46-2138300b2a28",
                            Name = "AccountsClerk",
                            NormalizedName = "ACCOUNTSCLERK"
                        },
                        new
                        {
                            Id = "c2a01f94-96bb-47f0-8e9f-16cd8b4b1016",
                            Name = "MediaManager",
                            NormalizedName = "MEDIAMANAGER"
                        },
                        new
                        {
                            Id = "838eafaf-019b-44ca-a386-acfca55de142",
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
                            UserId = "3dd92b8f-0050-4804-9890-1476a0383258",
                            RoleId = "75e8f28e-b7aa-48b5-8d41-5329c613ea4b"
                        },
                        new
                        {
                            UserId = "df1baf0b-daf3-4d54-bd7c-1f32d4d7d723",
                            RoleId = "a26009ae-cbd6-409b-b0b7-6ac8452b4702"
                        },
                        new
                        {
                            UserId = "1ea1452d-7d9c-4b5a-9853-90713d6486ca",
                            RoleId = "b7a3af63-7fa2-421d-88ab-5e7d603599a5"
                        },
                        new
                        {
                            UserId = "f652e8b0-eb90-4f09-b57e-00d6b80e1cab",
                            RoleId = "bc800078-c380-49ec-ae46-2138300b2a28"
                        },
                        new
                        {
                            UserId = "630981b0-5704-4e61-a7ed-e4bbdbb87509",
                            RoleId = "c2a01f94-96bb-47f0-8e9f-16cd8b4b1016"
                        },
                        new
                        {
                            UserId = "14ac25a6-7771-4284-9acb-1c5d72369674",
                            RoleId = "838eafaf-019b-44ca-a386-acfca55de142"
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

            modelBuilder.Entity("Maxicycles.Models.BasketProduct", b =>
                {
                    b.HasBaseType("Maxicycles.Models.BasketItem");

                    b.HasDiscriminator().HasValue("BasketProduct");
                });

            modelBuilder.Entity("Maxicycles.Models.BasketService", b =>
                {
                    b.HasBaseType("Maxicycles.Models.BasketItem");

                    b.Property<DateTime?>("ServiceDate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.HasDiscriminator().HasValue("BasketService");
                });

            modelBuilder.Entity("Maxicycles.Models.Product", b =>
                {
                    b.HasBaseType("Maxicycles.Models.Item");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("Product");
                });

            modelBuilder.Entity("Maxicycles.Models.Service", b =>
                {
                    b.HasBaseType("Maxicycles.Models.Item");

                    b.Property<int>("DailyMaxServices")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("Service");
                });

            modelBuilder.Entity("Maxicycles.Models.OrderProduct", b =>
                {
                    b.HasBaseType("Maxicycles.Models.OrderItem");

                    b.HasDiscriminator().HasValue("OrderProduct");
                });

            modelBuilder.Entity("Maxicycles.Models.OrderService", b =>
                {
                    b.HasBaseType("Maxicycles.Models.OrderItem");

                    b.Property<DateTime>("ServiceDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasDiscriminator().HasValue("OrderService");
                });

            modelBuilder.Entity("Maxicycles.Models.Card", b =>
                {
                    b.HasBaseType("Maxicycles.Models.Payment");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("text");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("text");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LongNumber")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Postcode")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Card");
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
                            Id = "3dd92b8f-0050-4804-9890-1476a0383258",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b20e6381-7d96-4d39-990b-fb01bd15e481",
                            Email = "customer@example.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "CUSTOMER@EXAMPLE.CO.UK",
                            NormalizedUserName = "CUSTOMER@EXAMPLE.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEAz0Dmtgjw4KM5J2Fg38El/mG1uaFHCkyfvQ2Z5hrd0JkoM5ob9tAFAtYCmQ1/3kjg==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "f91e618a-2ed3-4f49-95c9-a9c116610b51",
                            TwoFactorEnabled = false,
                            UserName = "customer@example.co.uk"
                        },
                        new
                        {
                            Id = "df1baf0b-daf3-4d54-bd7c-1f32d4d7d723",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "50d76ab5-f990-4027-a602-2f2572fc0c31",
                            Email = "stockControl@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "STOCKCONTROL@MAXICYCLES.CO.UK",
                            NormalizedUserName = "STOCKCONTROL@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEG7Tjbyi1txV5NELm1/gY+0XzFZ3brWKOXmshZpUq1FNwMtZOMiGy1gUXz30nDodqA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "1f8c2896-33e4-48ea-866a-90b218bc1cdd",
                            TwoFactorEnabled = false,
                            UserName = "stockControl@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "1ea1452d-7d9c-4b5a-9853-90713d6486ca",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9e3f1753-3455-4518-9afd-0a12309ff6bc",
                            Email = "technician@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TECHNICIAN@MAXICYCLES.CO.UK",
                            NormalizedUserName = "TECHNICIAN@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEJwpTV5JPPacKPGnvk25eIsAUEjkKTONxyrihmcl05fx+ygUBLmw6rcNHlvFzW/oNw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "0d74bc3b-2b28-4e2d-a7eb-b947c064dffd",
                            TwoFactorEnabled = false,
                            UserName = "technician@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "f652e8b0-eb90-4f09-b57e-00d6b80e1cab",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e0bc9319-307d-4021-9396-4c9aba7f9532",
                            Email = "accountsClerk@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                            NormalizedUserName = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEH0lIj5am5JCz7Y0/UTl8VnAIA4W57OVnJbJ+LGk9mUVJiComPHosM22sTHTk3FusQ==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "d183d3e1-ca11-4692-ab33-16bc519f6c23",
                            TwoFactorEnabled = false,
                            UserName = "accountsClerk@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "630981b0-5704-4e61-a7ed-e4bbdbb87509",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9e39e2ad-77f5-408a-a3a8-50f72c734619",
                            Email = "mediaManager@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                            NormalizedUserName = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAELNAIqS0p0R29RlacUGApk/GoRYF7fi97vZzc7MZLVLoqd+ON9Z8QnnyMSn+BV55Cw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "8c54b059-e82b-4209-b3a0-008c44221779",
                            TwoFactorEnabled = false,
                            UserName = "mediaManager@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "14ac25a6-7771-4284-9acb-1c5d72369674",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "35fbc778-da54-41e3-9cb5-d091f49f273d",
                            Email = "manager@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "MANAGER@MAXICYCLES.CO.UK",
                            NormalizedUserName = "MANAGER@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEHJ6Svx7vVdNZYd+erir97ZLGReMmZhyRGynxYSxYsO+OCEXzWcs498+47A/UyrzXA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "fe5815e8-bab9-4d3a-86af-ff657511ada2",
                            TwoFactorEnabled = false,
                            UserName = "manager@maxicycles.co.uk"
                        });
                });

            modelBuilder.Entity("Maxicycles.Models.BasketItem", b =>
                {
                    b.HasOne("Maxicycles.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maxicycles.Models.MaxicyclesUser", "MaxicyclesUser")
                        .WithMany("BasketItem")
                        .HasForeignKey("MaxicyclesUserId");

                    b.Navigation("Item");

                    b.Navigation("MaxicyclesUser");
                });

            modelBuilder.Entity("Maxicycles.Models.Item", b =>
                {
                    b.HasOne("Maxicycles.Models.Image", "Image")
                        .WithMany("Item")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maxicycles.Models.SubCategory", "SubCategory")
                        .WithMany("Items")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Maxicycles.Models.Order", b =>
                {
                    b.HasOne("Maxicycles.Models.DeliveryMethod", "DeliveryMethod")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Maxicycles.Models.MaxicyclesUser", "MaxicyclesUser")
                        .WithMany()
                        .HasForeignKey("MaxicyclesUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryMethod");

                    b.Navigation("MaxicyclesUser");
                });

            modelBuilder.Entity("Maxicycles.Models.OrderItem", b =>
                {
                    b.HasOne("Maxicycles.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Maxicycles.Models.Payment", b =>
                {
                    b.HasOne("Maxicycles.Models.Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("Maxicycles.Models.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
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

            modelBuilder.Entity("Maxicycles.Models.DeliveryMethod", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Maxicycles.Models.Image", b =>
                {
                    b.Navigation("Item");
                });

            modelBuilder.Entity("Maxicycles.Models.Order", b =>
                {
                    b.Navigation("Payment");
                });

            modelBuilder.Entity("Maxicycles.Models.SubCategory", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Maxicycles.Models.MaxicyclesUser", b =>
                {
                    b.Navigation("BasketItem");
                });
#pragma warning restore 612, 618
        }
    }
}
