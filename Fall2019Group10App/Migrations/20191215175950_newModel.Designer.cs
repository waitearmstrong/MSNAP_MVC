﻿// <auto-generated />
using System;
using Fall2019Group10App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fall2019Group10App.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191215175950_newModel")]
    partial class newModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fall2019Group10App.Models.Clinic", b =>
                {
                    b.Property<int>("ClinicID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClinicName")
                        .IsRequired();

                    b.Property<string>("ClinicStreetAddress")
                        .IsRequired();

                    b.Property<string>("ClinicZip")
                        .IsRequired();

                    b.HasKey("ClinicID");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.Fund", b =>
                {
                    b.Property<int>("FundID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnimalGender");

                    b.Property<string>("AnimalSize");

                    b.Property<string>("AnimalType");

                    b.Property<double>("Balance");

                    b.Property<string>("FundType")
                        .IsRequired();

                    b.HasKey("FundID");

                    b.ToTable("Funds");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.Request", b =>
                {
                    b.Property<int>("RequestID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnimalGender")
                        .IsRequired();

                    b.Property<string>("AnimalSize")
                        .IsRequired();

                    b.Property<string>("AnimalType")
                        .IsRequired();

                    b.Property<string>("OwnerID");

                    b.Property<int?>("VoucherID");

                    b.HasKey("RequestID");

                    b.HasIndex("OwnerID");

                    b.HasIndex("VoucherID");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.RequestVolunteer", b =>
                {
                    b.Property<int>("RequestVolunteerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RequestID");

                    b.Property<string>("VolunteerID");

                    b.HasKey("RequestVolunteerID");

                    b.HasIndex("RequestID");

                    b.HasIndex("VolunteerID");

                    b.ToTable("RequestVolunteers");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.VolunteerFund", b =>
                {
                    b.Property<int>("VolunteerFundID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FundID");

                    b.Property<string>("VolunteerID");

                    b.HasKey("VolunteerFundID");

                    b.HasIndex("FundID");

                    b.HasIndex("VolunteerID");

                    b.ToTable("VolunteerFunds");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.Voucher", b =>
                {
                    b.Property<int>("VoucherID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClinicID");

                    b.Property<DateTime?>("DateReconciled");

                    b.Property<DateTime>("DateSent");

                    b.Property<DateTime?>("DateUsed");

                    b.Property<int>("RequestID");

                    b.Property<double>("VoucherAmount");

                    b.HasKey("VoucherID");

                    b.HasIndex("ClinicID");

                    b.HasIndex("RequestID");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.VoucherFund", b =>
                {
                    b.Property<int>("VoucherFundId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FundID");

                    b.Property<int>("VoucherID");

                    b.HasKey("VoucherFundId");

                    b.HasIndex("FundID");

                    b.HasIndex("VoucherID");

                    b.ToTable("VoucherFunds");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.Owner", b =>
                {
                    b.HasBaseType("Fall2019Group10App.Models.ApplicationUser");

                    b.HasDiscriminator().HasValue("Owner");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.Volunteer", b =>
                {
                    b.HasBaseType("Fall2019Group10App.Models.ApplicationUser");

                    b.HasDiscriminator().HasValue("Volunteer");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.Request", b =>
                {
                    b.HasOne("Fall2019Group10App.Models.Owner", "Owner")
                        .WithMany("Requests")
                        .HasForeignKey("OwnerID");

                    b.HasOne("Fall2019Group10App.Models.Voucher", "Voucher")
                        .WithMany()
                        .HasForeignKey("VoucherID");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.RequestVolunteer", b =>
                {
                    b.HasOne("Fall2019Group10App.Models.Request", "Request")
                        .WithMany("RequestVolunteers")
                        .HasForeignKey("RequestID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fall2019Group10App.Models.Volunteer", "Volunteer")
                        .WithMany("RequestVolunteers")
                        .HasForeignKey("VolunteerID");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.VolunteerFund", b =>
                {
                    b.HasOne("Fall2019Group10App.Models.Fund", "Fund")
                        .WithMany("VolunteerFunds")
                        .HasForeignKey("FundID");

                    b.HasOne("Fall2019Group10App.Models.Volunteer", "Volunteer")
                        .WithMany("VolunteerFunds")
                        .HasForeignKey("VolunteerID");
                });

            modelBuilder.Entity("Fall2019Group10App.Models.Voucher", b =>
                {
                    b.HasOne("Fall2019Group10App.Models.Clinic", "Clinic")
                        .WithMany("Vouchers")
                        .HasForeignKey("ClinicID");

                    b.HasOne("Fall2019Group10App.Models.Request", "Request")
                        .WithMany()
                        .HasForeignKey("RequestID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fall2019Group10App.Models.VoucherFund", b =>
                {
                    b.HasOne("Fall2019Group10App.Models.Fund", "Fund")
                        .WithMany("VoucherFunds")
                        .HasForeignKey("FundID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fall2019Group10App.Models.Voucher", "Voucher")
                        .WithMany("VoucherFunds")
                        .HasForeignKey("VoucherID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
