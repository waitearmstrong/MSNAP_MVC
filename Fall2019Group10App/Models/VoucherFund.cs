using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Fall2019Group10App.Models
{
    public class VoucherFund
    {
        [Key]
        public int VoucherFundId { get; set; }
        
        public int VoucherID { get; set; }
        [ForeignKey("VoucherID")]
        public Voucher Voucher { get; set; }
        
        public int FundID { get; set; }
       [ForeignKey("FundID")]
        public Fund Fund { get; set; }

        public VoucherFund(int voucherID, int fundID)
        {
            this.VoucherID = voucherID;
            this.FundID = fundID;
        }
       
    }
}
