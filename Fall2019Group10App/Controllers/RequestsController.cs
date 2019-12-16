using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Fall2019Group10App.Data;
using Fall2019Group10App.Models;
using Fall2019Group10App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Fall2019Group10App.Controllers
{
    public class RequestsController : Controller
    {
        private ApplicationDbContext database;

            public RequestsController(ApplicationDbContext dbContext)
            {
                this.database = dbContext;
            }

            //Lambda Expression and LINQ
            public IActionResult ListAllRequests()
            {
                List<Request> requestList = database.Requests
                    .Include(o => o.Owner)
                    .ToList<Request>();

                return View(requestList);
            }

            public void PopulateDropDownLists()
            {
                ViewData["list"] = new SelectList(database.Requests);
            }
        [HttpGet]
            public IActionResult SearchRequests()
            {
                PopulateDropDownLists();
                SearchRequestsViewModel viewModel = new SearchRequestsViewModel();
                return View(viewModel);
            }
            [HttpPost]
             public IActionResult SearchRequests(SearchRequestsViewModel viewModel)
            {
                PopulateDropDownLists();
                List<Request> requestList = database.Requests
                .Include(o => o.Owner)
                .Include(v => v.Voucher)
                .ToList<Request>();

            if (viewModel.OwnerName != null)
            {
                requestList = requestList.Where(o =>o.Owner.FullName  == viewModel.OwnerName).ToList<Request>();
            }

            
            if (viewModel.AnimalSize != null)
            {
                requestList = requestList.Where(r => r.AnimalSize == viewModel.AnimalSize).ToList<Request>();
            }
            if (viewModel.AnimalType != null)
            {
                requestList = requestList.Where(r => r.AnimalType == viewModel.AnimalType).ToList<Request>();
            }

            if (viewModel.AnimalGender != null)
            {
                requestList = requestList.Where(r => r.AnimalGender == viewModel.AnimalGender).ToList<Request>();
            }

            viewModel.RequestList = requestList;
            return View(viewModel);
        }
            

    }
}