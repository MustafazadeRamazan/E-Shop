using eshop_srytr.Models.ApplicationServices.Abstraction;
using eshop_srytr.Models.Database;
using eshop_srytr.Models.Database.Entity;
using eshop_srytr.Models.Entity;
using eshop_srytr.Models.Identity;
using eshop_srytr.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_srytr.Controllers
{
    public class ProductController : Controller {
        readonly EshopDatabase eshopDbContext;
        ISecurityApplicationService security;

        public ProductController(EshopDatabase eshopDB, ISecurityApplicationService security) {
            eshopDbContext = eshopDB;
            this.security = security;
        }

        [HttpGet]
        public IActionResult Index(int id, string state) {
            var product = eshopDbContext.ProductItems.Where(p => p.ID == id).FirstOrDefault();
            var reviews = eshopDbContext.Reviews.Where(r => r.ProductId == id).Where(r => r.IsVisible == true).OrderByDescending(r => r.DateTimeCreated).ToList();

            foreach (var review in reviews) {
                review.UserName = eshopDbContext.Users.Where(u => u.Id == review.UserId).FirstOrDefault().UserName;
            }

            var model = new ProductViewModel(product, new Review());
            model.state = state;

            return View(model);
        }

        public IActionResult CreateReview()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateReview(Review review)
        {
            if (review != null)
            {
                review.UserId = eshopDbContext.Users.Where(u => u.UserName == review.UserName).FirstOrDefault().Id;

                if (ModelState.IsValid)
                {
                    var product = eshopDbContext.ProductItems.Where(p => p.ID == review.ProductId).FirstOrDefault();
                    var reviews = eshopDbContext.Reviews.Where(r => r.ProductId == review.ProductId).Where(r => r.IsVisible == true).OrderByDescending(r => r.DateTimeCreated).ToList();

                    if (!reviews.Any(r => r.UserId == review.UserId))
                    {
                        review.IsVisible = true;
                        eshopDbContext.Reviews.Add(review);
                        await eshopDbContext.SaveChangesAsync();

                        double productRating = 0;

                        foreach (var rev in reviews)
                        {
                            productRating += rev.ReviewRating;
                        }

                        productRating += review.ReviewRating;

                        if (product.Reviews != null)
                        {
                            product.ProductRating = productRating / product.Reviews.Count();
                        }
                        else
                        {
                            product.ProductRating = 0;
                        }

                        await eshopDbContext.SaveChangesAsync();

                        return RedirectToAction("Index", new { id = review.ProductId, state = "vytvoreno" });
                    } else
                    {
                        Console.WriteLine("You cannot add more reviews to one product");
                        return RedirectToAction("Index", new { id = review.ProductId, state = "chyba" });
                    }
                }                
            }

            return View(review);
        }

        public async Task<IActionResult> DeleteReview(int id) {

            DbSet<Review> reviews = eshopDbContext.Reviews;
            Review review = eshopDbContext.Reviews.Where(r => r.ID == id).FirstOrDefault();
            ProductItem product = eshopDbContext.ProductItems.Where(p => p.ID == review.ProductId).FirstOrDefault();
            User user = eshopDbContext.Users.Where(u => u.UserName == HttpContext.User.Identity.Name).FirstOrDefault();

            if (review != null && review.UserId == user.Id)
            {
                reviews.Remove(review);
                await eshopDbContext.SaveChangesAsync();

                double productRating = 0;
                foreach (var rev in eshopDbContext.Reviews.Where(r => r.ProductId == review.ProductId).Where(r => r.IsVisible == true).ToList()) {
                    productRating += rev.ReviewRating;
                }
                product.ProductRating = productRating / product.Reviews.Count();

                await eshopDbContext.SaveChangesAsync();
            } else
            {
                Console.WriteLine("You cannot delete somneone else's review.");
            }

            return RedirectToAction("Index", new { id = review.ProductId, state = "vytvoreno" });
        }
    }
}
