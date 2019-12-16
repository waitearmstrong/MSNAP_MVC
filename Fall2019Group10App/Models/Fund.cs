using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging.Abstractions;

namespace Fall2019Group10App.Models
{
    public class Fund
    {
        [Key]
        public int FundID { get; set; }
        [Required]
        public double Balance { get; set; }
        [Required]
        public String FundType { get; set; }

        public String AnimalSize { get; set; }
        public String AnimalType { get; set; }
        public String AnimalGender { get; set; }

        public List<VolunteerFund> VolunteerFunds { get; set; }
        public List<VoucherFund> VoucherFunds { get; set; }

        public Fund(double balance, string fundType)
        {
            this.Balance = balance;
            this.FundType = fundType;
            this.AnimalGender = null;
            this.AnimalSize = null;
            this.AnimalType = null;
        }
        public Fund(double balance,string fundType,string animalSize,string animalGender, string animalType)
        {
            this.Balance = balance;
            this.FundType = fundType;
            this.AnimalSize = animalSize;
            this.AnimalGender = animalGender;
            this.AnimalType = animalType;
        }
    }
}
