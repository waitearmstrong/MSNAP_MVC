using System;
using System.Collections.Generic;
using System.Text;
using Fall2019Group10App.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Fall2019Group10App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Clinic> Clinics { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Fund> Funds { get; set; }
        public DbSet<VolunteerFund> VolunteerFunds { get; set; }
        public DbSet<VoucherFund> VoucherFunds { get; set; }
        public DbSet<RequestVolunteer> RequestVolunteers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        

    } // end of class
} //end of namespace 
