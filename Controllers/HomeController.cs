using eshop_srytr.Models;
using eshop_srytr.Models.Database;
using eshop_srytr.Models.Database.Entity;
using eshop_srytr.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_srytr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EshopDatabase _dbContext;

        public HomeController(ILogger<HomeController> logger, EshopDatabase dbContext)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IndexViewModel indexVM = new IndexViewModel();
            indexVM.CarouselItems = _dbContext.CarouselItems.ToList();
            indexVM.ProductItems = _dbContext.ProductItems.ToList();
            
            return View(indexVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
