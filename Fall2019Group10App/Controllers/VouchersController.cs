using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fall2019Group10App.Data;
using Fall2019Group10App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fall2019Group10App.Controllers
{
    public class VouchersController : Controller
    {
        private ApplicationDbContext database;

        public VouchersController(ApplicationDbContext dbContext)
        {
            this.database = dbContext;
        }

        //Lambda Expression and LINQ
        public IActionResult ListAllVouchers()
        {
            List<Voucher> voucherList = database.Vouchers
                .Include(r => r.Request)
                    .ThenInclude(o => o.Owner)
                .Include(c => c.Clinic)
                .ToList<Voucher>();

            return View(voucherList);
        }
    }
}