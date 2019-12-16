using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Fall2019Group10App.Models
{
    public class VolunteerFund
    {
        [Key]
        public int VolunteerFundID { get; set; }

        //ISSUE HERE
        //Cannot create foreign key links to volunteer or owner class because they are strings
        public String VolunteerID { get; set; }
        [ForeignKey("VolunteerID")]
        public Volunteer Volunteer { get; set; }
        public int? FundID { get; set; }
        // [ForeignKey("FundID")]
        public Fund Fund { get; set; }

        public VolunteerFund()
        {
        }

        public VolunteerFund(string volunteerID, int fundId)
        {
            this.VolunteerID = volunteerID;
            this.FundID = fundId;
        }
    }
}
