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
    [Migration("20230405172715_AddImageToProduct")]
    partial class AddImageToProduct
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

            modelBuilder.Entity("Maxicycles.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

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
                            Id = "ac67caff-32b6-432a-8a1f-bd0814587590",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "e37183a5-3e8b-4fe2-a345-5adba6875291",
                            Name = "StockControl",
                            NormalizedName = "STOCKCONTROL"
                        },
                        new
                        {
                            Id = "9bc6099b-4beb-42a3-97c9-dde0d7f52463",
                            Name = "Technician",
                            NormalizedName = "TECHNICIAN"
                        },
                        new
                        {
                            Id = "16ab2839-40d9-43ce-9694-f51cf0f7c192",
                            Name = "AccountsClerk",
                            NormalizedName = "ACCOUNTSCLERK"
                        },
                        new
                        {
                            Id = "24de28c4-22e5-46f4-a839-7ae36a55b380",
                            Name = "MediaManager",
                            NormalizedName = "MEDIAMANAGER"
                        },
                        new
                        {
                            Id = "7d10ac94-9669-4cd4-8d3e-251ea4c4869f",
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
                            UserId = "9baf8e49-2ce1-4dfb-a624-2cee4c007971",
                            RoleId = "ac67caff-32b6-432a-8a1f-bd0814587590"
                        },
                        new
                        {
                            UserId = "01239541-bb62-4795-a274-751a765f7b91",
                            RoleId = "e37183a5-3e8b-4fe2-a345-5adba6875291"
                        },
                        new
                        {
                            UserId = "0c97a4ce-9599-40e8-9e9f-049412b33eee",
                            RoleId = "9bc6099b-4beb-42a3-97c9-dde0d7f52463"
                        },
                        new
                        {
                            UserId = "8e0ea4e8-926c-4291-b6f2-0a2defddf7bb",
                            RoleId = "16ab2839-40d9-43ce-9694-f51cf0f7c192"
                        },
                        new
                        {
                            UserId = "649645e4-cdfd-448e-960f-c506a72f6186",
                            RoleId = "24de28c4-22e5-46f4-a839-7ae36a55b380"
                        },
                        new
                        {
                            UserId = "d468a07f-4262-4e4a-a595-dc3a5e146d5d",
                            RoleId = "7d10ac94-9669-4cd4-8d3e-251ea4c4869f"
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
                            Id = "9baf8e49-2ce1-4dfb-a624-2cee4c007971",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d03263ed-1d7a-4b86-a78c-c6affab790ee",
                            Email = "customer@example.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "CUSTOMER@EXAMPLE.CO.UK",
                            NormalizedUserName = "CUSTOMER@EXAMPLE.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEGSL8zn9qay081agLn1PdrEPYcdHSFd1D8IiNgVr3kl7TC9D9aSblHw5cdN7kJYMGg==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "8852c8fa-ab07-49a8-991d-eca92e76292d",
                            TwoFactorEnabled = false,
                            UserName = "customer@example.co.uk"
                        },
                        new
                        {
                            Id = "01239541-bb62-4795-a274-751a765f7b91",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7618fdd0-7851-4253-9407-c00ef4413998",
                            Email = "stockControl@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "STOCKCONTROL@MAXICYCLES.CO.UK",
                            NormalizedUserName = "STOCKCONTROL@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAECMQsDGmAoqJ0V/9FfOB+b1uWngTZMdMkMOaNU7qgDE0WkxUOYONZOKy856qRfey7A==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "66cd2236-15da-4d75-ae3f-d312e8577709",
                            TwoFactorEnabled = false,
                            UserName = "stockControl@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "0c97a4ce-9599-40e8-9e9f-049412b33eee",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ac9bfe48-82f8-476b-84f9-eb6a4962aeab",
                            Email = "technician@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "TECHNICIAN@MAXICYCLES.CO.UK",
                            NormalizedUserName = "TECHNICIAN@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEDMsAHNrIcnguF5xa53P63KkcScZ0XoOrrbiKcjoSMi8VKimOOCi9vjJr8HdP3Ia/w==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "33c5ec47-c9c5-455b-ad23-abd97df2e43a",
                            TwoFactorEnabled = false,
                            UserName = "technician@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "8e0ea4e8-926c-4291-b6f2-0a2defddf7bb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "96d875a4-9421-44f6-a3d3-99bce7cdc5e0",
                            Email = "accountsClerk@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                            NormalizedUserName = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAECRifxvCUE57LFwwSxtFomqgEgLmCsiVTNkVHhXDsPJk20x2HkDeciUT9I/7dPcQ7w==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "d74e4cdd-0f0c-4126-ab2f-343c2257bccc",
                            TwoFactorEnabled = false,
                            UserName = "accountsClerk@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "649645e4-cdfd-448e-960f-c506a72f6186",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1df6639c-855d-420b-a4a6-6fff61b3683c",
                            Email = "mediaManager@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                            NormalizedUserName = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEKtQXfZdLUDxQNEm4gBESyWUMo/JwNvf+0vCHrmBF98m3Y3u1w2LS7Jh3XUJG2JfQw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "441cae6c-f2be-402e-85e3-79054eb65bcd",
                            TwoFactorEnabled = false,
                            UserName = "mediaManager@maxicycles.co.uk"
                        },
                        new
                        {
                            Id = "d468a07f-4262-4e4a-a595-dc3a5e146d5d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f2e039f7-e014-4b30-bc98-ee3b79e726ad",
                            Email = "manager@maxicycles.co.uk",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "MANAGER@MAXICYCLES.CO.UK",
                            NormalizedUserName = "MANAGER@MAXICYCLES.CO.UK",
                            PasswordHash = "AQAAAAIAAYagAAAAEJjfBxjVbnsmKWCb9IT/SBlomjpbm0MmZ7xUTFmwjfBCWTj9Jo8w45nflTE/a6RpPA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "a33e8ac2-feb1-443b-9f1f-77a8cd47e7d5",
                            TwoFactorEnabled = false,
                            UserName = "manager@maxicycles.co.uk"
                        });
                });

            modelBuilder.Entity("Maxicycles.Models.Product", b =>
                {
                    b.HasOne("Maxicycles.Models.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

            modelBuilder.Entity("Maxicycles.Models.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
