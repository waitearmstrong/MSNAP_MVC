using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Fall2019Group10App.Models
{
    public class Volunteer : ApplicationUser
    {
        public List<VolunteerFund> VolunteerFunds { get; set; }
        public List<RequestVolunteer> RequestVolunteers { get; set; }
        public Volunteer() { }
        public Volunteer(string firstName, string lastName, string email, string phoneNumber, string password)
            : base(firstName, lastName, email, phoneNumber, password)
        {

        }
    }
}
