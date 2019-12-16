using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2019Group10App.Models
{
    public class Request
    {
        [Key]
        public int RequestID { get; set; }
        [Required]
        public String AnimalGender { get; set; }
        [Required]
        public String AnimalSize { get; set; }
        [Required]
        public String AnimalType { get; set; }

        public int? VoucherID { get; set; }
        [ForeignKey("VoucherID")]
        public Voucher Voucher { get; set; }

        public String OwnerID { get; set; }
        [ForeignKey("OwnerID")]
        public Owner Owner { get; set; }
      
        public List<RequestVolunteer> RequestVolunteers { get; set; }

        public Request()
        {

        }
        public Request(string animalGender,string animalSize,string animalType)
        {
            this.AnimalGender = animalGender;
            this.AnimalSize = animalSize;
            this.AnimalType = animalType;
        }
    }
}
