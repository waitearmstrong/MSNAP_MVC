using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Fall2019Group10App.Models;

namespace Fall2019Group10App.ViewModels
{
    public class SearchRequestsViewModel
    {
        public int RequestID { get; set; }
        public String OwnerName { get; set; }

        public String AnimalType { get; set; }
        public String AnimalSize { get; set; }
        public String AnimalGender { get; set; }
        [DataType(DataType.Currency)]
        public Double VoucherAmount { get; set; }

        public List<Request> RequestList { get; set; }


    }
}
