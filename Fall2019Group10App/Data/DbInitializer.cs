﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fall2019Group10App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Fall2019Group10App.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(IServiceProvider services)
        {
            ApplicationDbContext database = services.GetRequiredService<ApplicationDbContext>();

            UserManager<ApplicationUser> userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

            RoleManager<IdentityRole> roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            string roleV = "Volunteer";
            string roleO = "Owner";

            if (!database.Roles.Any())
            {

                IdentityRole roleVolunteer = new IdentityRole(roleV);
                await roleManager.CreateAsync(roleVolunteer);
                IdentityRole roleOwner = new IdentityRole(roleO);
                await roleManager.CreateAsync(roleOwner);
                database.SaveChanges();
            }
            if (!database.ApplicationUsers.Any())
            {
                
                 Volunteer volunteerOne = new Volunteer("Volunteer", "One", "volunteer.one@gmail.com", "540.261.2644", "volunteer");
                await userManager.CreateAsync(volunteerOne);
                await userManager.AddToRoleAsync(volunteerOne, roleV);

                Owner ownerOne = new Owner("Waite", "Armstrong", "wha0001@mix.wvu.edu", "540.461.0083", "password");
                await userManager.CreateAsync(ownerOne);
                await userManager.AddToRoleAsync(ownerOne, roleO);

                Owner ownerTwo = new Owner("Crazy", "Catlady", "catlover@gmail.com", "760.461.5083", "catlover1");
                await userManager.CreateAsync(ownerTwo);
                await userManager.AddToRoleAsync(ownerTwo, roleO);
                
                Owner ownerThree = new Owner("Matt", "McDonald'", "matt.mcdonald@gmail.com", "763.431.5383", "mattyice");
                await userManager.CreateAsync(ownerThree);
                await userManager.AddToRoleAsync(ownerThree, roleO);


            }

            if (!database.Clinics.Any())
            {
                Clinic clinicOne = new Clinic("Brookvalley Veterinary Clinic", "19 Carrol Rd.", "26505");
                database.Clinics.Add(clinicOne);
                clinicOne = new Clinic("Morgantown Veterinary Care", "149 North Main Street", "26505");
                database.Clinics.Add(clinicOne);
                database.SaveChanges();
            }
            if (!database.Requests.Any())
            {
                

                Request requestOne = new Request("Female", "Small", "Cat");
                Request requestTwo = new Request("Male", "Medium", "Dog");
                Request requestThree = new Request("Female", "Medium", "Cat");
                Request requestFour = new Request("Male", "Large", "Dog");
                Request requestFive = new Request("Female", "Large", "Cat");
                requestOne.Owner = database.Owners.FirstOrDefault(o => o.Email == "catlover@gmail.com");
                requestTwo.Owner = database.Owners.FirstOrDefault(o => o.Email == "wha0001@mix.wvu.edu");
                requestThree.Owner = database.Owners.FirstOrDefault(o => o.Email == "catlover@gmail.com");
                requestFour.Owner = database.Owners.FirstOrDefault(o => o.Email == "matt.mcdonald@gmail.com");
                requestFive.Owner = database.Owners.FirstOrDefault(o => o.Email == "matt.mcdonald@gmail.com");
                database.Requests.Add(requestOne);
                database.Requests.Add(requestTwo);
                database.Requests.Add(requestThree);
                database.Requests.Add(requestFour);
                database.Requests.Add(requestFive);

                database.SaveChanges();
            }
            if (!database.Vouchers.Any())
            {
                DateTime date = new DateTime(2019, 3, 1);
                DateTime dateTwo = new DateTime(2019, 7, 14);
                DateTime dateThree = new DateTime(2019, 1, 14);
                Voucher voucherOne = new Voucher(50.00,date,1,1);
                Voucher voucherTwo = new Voucher(25.00, dateTwo, 2, 2);
                Voucher voucherThree = new Voucher(75.00, dateThree, 2, 34);
                Voucher voucherFour = new Voucher(15.00,dateThree,1,35);
                voucherOne.RequestID = 31;
                voucherTwo.RequestID = 32;
                voucherThree.RequestID = 34;
                voucherFour.RequestID = 35;
                voucherThree.DateReconciled = date;
                voucherFour.DateReconciled = dateTwo;
                database.Vouchers.Add(voucherOne);
                database.Vouchers.Add(voucherTwo);
                database.Vouchers.Add(voucherThree);
                database.Vouchers.Add(voucherFour);
                database.SaveChanges();
            }
          
           
            if (!database.Funds.Any())
            {
                Fund fundOne = new Fund(100.00,"Donation");
                Fund fundTwo = new Fund(1000.00, "Donation");
                database.Funds.Add(fundOne);
                database.Funds.Add(fundTwo);
                database.SaveChanges();
            }
            


        }
    }
}
