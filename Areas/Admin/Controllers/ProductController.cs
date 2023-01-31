using eshop_srytr.Models.Database;
using eshop_srytr.Models.Database.Entity;
using eshop_srytr.Models.Entity;
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
    public class ProductController : Controller
    {
        readonly EshopDatabase eshopDbContext;
        IWebHostEnvironment env;
        public ProductController(EshopDatabase eshopDB, IWebHostEnvironment env)
        {
            eshopDbContext = eshopDB;
            this.env = env;
        }
        public IActionResult Select()
        {
            IList<ProductItem> productItems = eshopDbContext.ProductItems.ToList();
            foreach (var product in productItems) {
                var reviews = eshopDbContext.Reviews.Where(r => r.ProductId == product.ID).OrderByDescending(r => r.DateTimeCreated).ToList();

                foreach (var review in reviews) {
                    review.UserName = eshopDbContext.Users.Where(u => u.Id == review.UserId).FirstOrDefault().UserName;
                }
            }

            return View(productItems);

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductItem productItem)
        {
            if (productItem != null && productItem.Image != null)
            {
                FileUpload fileUpload = new FileUpload(env.WebRootPath, "img/ProductItems", "image");
                productItem.ImageSource = await fileUpload.FileUploadAsync(productItem.Image);

                productItem.Reviews = new List<Review>();
                productItem.ProductRating = 0;

                if (String.IsNullOrWhiteSpace(productItem.ImageSource) == false)
                {

                    eshopDbContext.ProductItems.Add(productItem);
                    await eshopDbContext.SaveChangesAsync();

                    return RedirectToAction(nameof(ProductController.Select));

                }
            }
            return View(productItem);

        }

        public IActionResult Edit(int ID)
        {
            ProductItem ciFromDatabase = eshopDbContext.ProductItems.FirstOrDefault(ci => ci.ID == ID);
            if (ciFromDatabase != null)
            {
                return View(ciFromDatabase);

            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductItem productItem)
        {
            ProductItem piFromDatabase = eshopDbContext.ProductItems.FirstOrDefault(pi => pi.ID == productItem.ID);
            if (piFromDatabase != null)
            {
                if (productItem != null && productItem.Image != null)
                {
                    FileUpload fileUpload = new FileUpload(env.WebRootPath, "img/ProductItems", "image");
                    productItem.ImageSource = await fileUpload.FileUploadAsync(productItem.Image);

                    if (String.IsNullOrWhiteSpace(productItem.ImageSource) == false)
                    {


                        piFromDatabase.ImageSource = productItem.ImageSource;
                    }
                }
                piFromDatabase.ImageAlt = productItem.ImageAlt;

                piFromDatabase.Price = productItem.Price;

                piFromDatabase.Info = productItem.Info;

                await eshopDbContext.SaveChangesAsync();

                return RedirectToAction(nameof(ProductController.Select));
            }
            else
            {
                return NotFound();
            }

        }
        public async Task<IActionResult> Delete(int ID)
        {
            DbSet<ProductItem> productItems = eshopDbContext.ProductItems;

            ProductItem productItem = productItems.Where(productItem => productItem.ID == ID).FirstOrDefault();

            if (productItem != null)
            {
                productItems.Remove(productItem);
                await eshopDbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(ProductController.Select));
        }

        public async Task<IActionResult> DeleteReview(int id)
        {
            DbSet<Review> reviews = eshopDbContext.Reviews;
            Review review = eshopDbContext.Reviews.Where(r => r.ID == id).FirstOrDefault();
            ProductItem product = eshopDbContext.ProductItems.Where(p => p.ID == review.ProductId).FirstOrDefault();

            // If review is found
            if (review != null)
            {
                // Remove the review
                reviews.Remove(review);
                await eshopDbContext.SaveChangesAsync();

                // Update product's rating
                double productRating = 0;
                foreach (var rev in eshopDbContext.Reviews.Where(r => r.ProductId == review.ProductId).Where(r => r.IsVisible == true).ToList())
                {
                    productRating += rev.ReviewRating;
                }

                product.ProductRating = productRating / product.Reviews.Count();

                await eshopDbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(ProductController.Select));
        }


        public async Task<IActionResult> ToggleReview(int id)
        {
            Review review = eshopDbContext.Reviews.Where(r => r.ID == id).FirstOrDefault();
            ProductItem product = eshopDbContext.ProductItems.Where(p => p.ID == review.ProductId).FirstOrDefault();

            // If review is found
            if (review != null) {
                // Toggle visibility
                review.IsVisible = !review.IsVisible; // toggle value
                await eshopDbContext.SaveChangesAsync();

                // recalculate rating ratio
                double productRating = 0;
                double visibleItems = 0;
                
                foreach (var rev in eshopDbContext.Reviews.Where(r => r.ProductId == review.ProductId).Where(r => r.IsVisible == true).ToList()) {                    
                    visibleItems++;
                    productRating += rev.ReviewRating;
                }

                product.ProductRating = productRating / visibleItems;

                await eshopDbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(ProductController.Select));
        }

        [HttpPost]
        public async Task<IActionResult> EditReview(Review review)
        {
            Review itemEdit = eshopDbContext.Reviews.FirstOrDefault(r => r.ID == review.ID);

            if (itemEdit != null) {
                // Update comment
                if (review.ReviewComment != itemEdit.ReviewComment) {
                    itemEdit.ReviewComment = review.ReviewComment;

                    await eshopDbContext.SaveChangesAsync();
                }

                // Update rating
                if (review.ReviewRating != itemEdit.ReviewRating) {
                    itemEdit.ReviewRating = review.ReviewRating;
                    await eshopDbContext.SaveChangesAsync(); // Save the new rating value first

                    if (itemEdit.IsVisible) { // if review is visible recalculate product rating ratio
                        ProductItem product = eshopDbContext.ProductItems.Where(p => p.ID == review.ProductId).FirstOrDefault();

                        // Update product's rating
                        double productRating = 0;
                        foreach (var rev in eshopDbContext.Reviews.Where(r => r.ProductId == review.ProductId).Where(r => r.IsVisible == true).ToList())
                        {
                            productRating += rev.ReviewRating;
                        }
                        product.ProductRating = productRating / product.Reviews.Count();

                        await eshopDbContext.SaveChangesAsync();
                    }
                }

            }

            return RedirectToAction(nameof(ProductController.Select));
        }
    }
}
