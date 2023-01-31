using eshop_srytr.Models.Database;
using eshop_srytr.Models.Database.Entity;
using eshop_srytr.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Srytr.Eshop.Web.Models.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_srytr.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + ", " + nameof(Roles.Manager))]
    public class CarouselController : Controller
    {
        readonly EshopDatabase eshopDbContext;
        IWebHostEnvironment env;

        public CarouselController(EshopDatabase eshopDB, IWebHostEnvironment env) {
            eshopDbContext = eshopDB;
            this.env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Select()
        {
            IList<CarouselItem> carouselItems = eshopDbContext.CarouselItems.ToList();

            return View(carouselItems);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CarouselItem carouselItem)
        {

            if (carouselItem != null && carouselItem.Image != null) {
                FileUpload fileUpload = new FileUpload(env.WebRootPath, "img/CarouselItems", "image");
                carouselItem.ImageSource = await fileUpload.FileUploadAsync(carouselItem.Image);

                // TryValidateModel(carouselItem);
                ModelState.Clear();
                if (ModelState.IsValid) {
                    eshopDbContext.CarouselItems.Add(carouselItem);
                    await eshopDbContext.SaveChangesAsync();

                    return RedirectToAction(nameof(CarouselController.Select));
                }
            }

            return View(carouselItem);
        }

        public async Task<IActionResult> Edit(int ID)
        {
            CarouselItem ciFromDatabase = eshopDbContext.CarouselItems.FirstOrDefault(ci => ci.ID == ID);

            if (ciFromDatabase != null) {
                await eshopDbContext.SaveChangesAsync();

                return View(ciFromDatabase);
            } else {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CarouselItem carouselItem) {
            CarouselItem ciFromDatabase = eshopDbContext.CarouselItems.FirstOrDefault(ci => ci.ID == carouselItem.ID);

            if (ciFromDatabase != null) {
                if (carouselItem != null && carouselItem.Image != null) {
                    FileUpload fileUpload = new FileUpload(env.WebRootPath, "img/CarouselItems", "image");
                    carouselItem.ImageSource = await fileUpload.FileUploadAsync(carouselItem.Image);
                }

                if (String.IsNullOrWhiteSpace(carouselItem.ImageSource) == false) {
                    ciFromDatabase.ImageSource = carouselItem.ImageSource;
                }

                if (String.IsNullOrWhiteSpace(carouselItem.ImageAlt) == false) {
                    ciFromDatabase.ImageAlt = carouselItem.ImageAlt;
                }

                await eshopDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(CarouselController.Select));
            } else {
                return NotFound();
            }
        }

        public async Task<IActionResult> Delete(int ID)
        {
            DbSet<CarouselItem> carouselItems = eshopDbContext.CarouselItems;

            CarouselItem carouselItem = carouselItems.Where(carouselItem => carouselItem.ID == ID)
                                                     .FirstOrDefault();

            // If item is found
            if (carouselItem != null) {
                carouselItems.Remove(carouselItem);

                await eshopDbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(CarouselController.Select));
        }
    }
}
