using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2019Group10App.Models
{
    public class Voucher
    {
        [Key]
        public int VoucherID { get; set; }
        [Required]
        public Double VoucherAmount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateSent { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateReconciled { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateUsed { get; set; }


        public int RequestID { get; set; }
        [ForeignKey("RequestID")]
        public Request Request { get; set; }

        public int? ClinicID { get; set; }
        [ForeignKey("ClinicID")]
        public Clinic Clinic { get; set; }

        public List<VoucherFund> VoucherFunds { get; set; }

        public Voucher() { }

        public Voucher(double voucherAmount,DateTime dateSent)
        {
            this.VoucherAmount = voucherAmount;
            this.DateSent = DateSent;
        }

        public Voucher(double voucherAmount,DateTime datesent,int clinicID,int requestID )
        {
            this.VoucherAmount = voucherAmount;
            this.DateSent = DateSent;
            this.ClinicID = clinicID;
            this.RequestID = requestID;
        }

        

    }
}
