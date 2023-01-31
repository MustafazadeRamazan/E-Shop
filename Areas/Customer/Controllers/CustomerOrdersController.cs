using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eshop_srytr.Models.ApplicationServices.Abstraction;
using eshop_srytr.Models.Database;
using eshop_srytr.Models.Entity;
using eshop_srytr.Models.Identity;

namespace eshop_srytr.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = nameof(Roles.Customer))]
    public class CustomerOrdersController : Controller
    {

        ISecurityApplicationService iSecure;
        EshopDatabase EshopDbContext;

        public CustomerOrdersController(ISecurityApplicationService iSecure, EshopDatabase eshopDBContext)
        {
            this.iSecure = iSecure;
            EshopDbContext = eshopDBContext;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                User currentUser = await iSecure.GetCurrentUser(User);
                if (currentUser != null)
                {
                    IList<Order> userOrders = await this.EshopDbContext.Orders
                                                                        .Where(or => or.UserId == currentUser.Id)
                                                                        .Include(o => o.User)
                                                                        .Include(o => o.OrderItems)
                                                                        .ThenInclude(oi => oi.Product)
                                                                        .ToListAsync();
                    return View(userOrders);
                }
            }

            return NotFound();
        }
    }
}
