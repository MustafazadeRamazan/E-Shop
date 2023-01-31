using eshop_srytr.Models.Database.Entity;
using eshop_srytr.Models.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_srytr.Models.Database
{
    public class DatabaseInit
    {
        public void Initialize(EshopDatabase eshopDbContext) {
            eshopDbContext.Database.EnsureCreated();

            if (eshopDbContext.CarouselItems.Count() == 0) {
                IList<CarouselItem> carouselItems = GenerateCarouselItem();

                foreach (var ci in carouselItems) {
                    eshopDbContext.CarouselItems.Add(ci);
                }

                eshopDbContext.SaveChanges();
            }

            if (eshopDbContext.ProductItems.Count() == 0)
            {
                IList<ProductItem> productsItems = GenerateProductItem();

                foreach (var pi in productsItems)
                {
                    eshopDbContext.ProductItems.Add(pi);
                }

                eshopDbContext.SaveChanges();
            }
        }

        public List<CarouselItem> GenerateCarouselItem() {
            List<CarouselItem> carouselItems = new List<CarouselItem>();

            CarouselItem ci1 = new CarouselItem()
            {
                ID = 1,
                ImageSource = "/img/pic1.jpg",
                ImageAlt = "Obrázek1"
            };

            CarouselItem ci2 = new CarouselItem()
            {
                ID = 2,
                ImageSource = "/img/pic2.jpg",
                ImageAlt = "Obrázek2"
            };

            CarouselItem ci3 = new CarouselItem()
            {
                ID = 3,
                ImageSource = "/img/pic3.jpg",
                ImageAlt = "Obrázek3"
            };

            carouselItems.Add(ci1);
            carouselItems.Add(ci2);
            carouselItems.Add(ci3);

            return carouselItems;
        }

        public List<ProductItem> GenerateProductItem()
        {
            List<ProductItem> productItems = new List<ProductItem>();

            ProductItem ci1 = new ProductItem()
            {
                ID = 1,
                Name = "Test produkt 1",
                ImageSource = "/img/pic1.jpg",
                Price = 500,
                Info = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam"
            };

            ProductItem ci2 = new ProductItem()
            {
                ID = 2,
                Name = "Test produkt 2",
                ImageSource = "/img/pic2.jpg",
                Price = 1299,
                Info = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam"
            };

            ProductItem ci3 = new ProductItem()
            {
                ID = 3,
                Name = "Test produkt 3",
                ImageSource = "/img/pic3.jpg",
                Price = 249,
                Info = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam"
            };

            productItems.Add(ci1);
            productItems.Add(ci2);
            productItems.Add(ci3);

            return productItems;
        }

        public async Task EnsureRoleCreated(RoleManager<Role> roleManager)
        {
            string[] roles = Enum.GetNames(typeof(Roles));

            foreach (var role in roles)
            {
                await roleManager.CreateAsync(new Role(role));
            }
        }

        public async Task EnsureAdminCreated(UserManager<User> userManager)
        {
            User user = new User
            {
                UserName = "admin",
                Email = "admin@admin.cz",
                EmailConfirmed = true,
                FirstName = "jmeno",
                LastName = "prijmeni"
            };
            string password = "abc";

            User adminInDatabase = await userManager.FindByNameAsync(user.UserName);

            if (adminInDatabase == null)
            {

                IdentityResult result = await userManager.CreateAsync(user, password);

                if (result == IdentityResult.Success)
                {
                    string[] roles = Enum.GetNames(typeof(Roles));
                    foreach (var role in roles)
                    {
                        await userManager.AddToRoleAsync(user, role);
                    }
                }
                else if (result != null && result.Errors != null && result.Errors.Count() > 0)
                {
                    foreach (var error in result.Errors)
                    {
                        Debug.WriteLine($"Error during Role creation for Admin: {error.Code}, {error.Description}");
                    }
                }
            }

        }

        public async Task EnsureManagerCreated(UserManager<User> userManager)
        {
            User user = new User
            {
                UserName = "manager",
                Email = "manager@manager.cz",
                EmailConfirmed = true,
                FirstName = "jmeno",
                LastName = "prijmeni"
            };
            string password = "abc";

            User managerInDatabase = await userManager.FindByNameAsync(user.UserName);

            if (managerInDatabase == null)
            {

                IdentityResult result = await userManager.CreateAsync(user, password);

                if (result == IdentityResult.Success)
                {
                    string[] roles = Enum.GetNames(typeof(Roles));
                    foreach (var role in roles)
                    {
                        if (role != Roles.Admin.ToString())
                            await userManager.AddToRoleAsync(user, role);
                    }
                }
                else if (result != null && result.Errors != null && result.Errors.Count() > 0)
                {
                    foreach (var error in result.Errors)
                    {
                        Debug.WriteLine($"Error during Role creation for Manager: {error.Code}, {error.Description}");
                    }
                }
            }

        }
    }
}
