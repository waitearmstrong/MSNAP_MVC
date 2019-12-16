using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Fall2019Group10App.Models
{
    public class RequestVolunteer
    {
        [Key]
        public int RequestVolunteerID { get; set; }
        public String VolunteerID { get; set; }
        [ForeignKey("VolunteerID")]
        public Volunteer Volunteer { get; set; }

        public int RequestID {get; set;}
        [ForeignKey("RequestID")]
        public Request Request { get; set; }

        public RequestVolunteer(){}
        public RequestVolunteer(string volunteerId, int requestId)
        {
            this.VolunteerID = volunteerId;
            this.RequestID = requestId;
        }
    }
}
