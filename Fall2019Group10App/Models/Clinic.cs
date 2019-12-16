using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2019Group10App.Models
{
    public class Clinic
    {
        [Key]
        public int ClinicID { get; set; }

        [Required]
        public String ClinicName { get; set; }
        [Required] 
        public String ClinicStreetAddress { get; set; }
        [Required]
        public String ClinicZip { get; set; }

        public List<Voucher> Vouchers { get; set; }

        public Clinic() { }

        public Clinic(String ClinicName, String clinicStreetAddress, String clinicZip)
        {
            this.ClinicName = ClinicName;
            this.ClinicStreetAddress = clinicStreetAddress;
            this.ClinicZip = clinicZip;
        }

    }
}
