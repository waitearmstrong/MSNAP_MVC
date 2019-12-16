using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2019Group10App.Models
{
    public class Owner : ApplicationUser
    {
        public List<Request> Requests { get; set; }

        public Owner()
        {

        }
        public Owner(string firstName, string lastName, string email, string phoneNumber, string password)
            : base(firstName, lastName, email, phoneNumber, password)
        {
           
        }
    }
}
