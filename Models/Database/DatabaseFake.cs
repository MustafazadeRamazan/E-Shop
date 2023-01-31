using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_srytr.Models.Database
{
    public static class DatabaseFake
    {
        public static List<Entity.CarouselItem> CarouselItems;
        public static List<Entity.ProductItem> ProductItems;

        static DatabaseFake() {
            DatabaseInit dbInit = new DatabaseInit();

            CarouselItems = dbInit.GenerateCarouselItem();
            ProductItems = dbInit.GenerateProductItem();
        }
    }
}
