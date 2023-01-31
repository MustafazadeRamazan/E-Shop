using eshop_srytr.Models.Database.Entity;
using eshop_srytr.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_srytr.Models.ViewModels
{
    public class IndexViewModel
    {
        public IList<CarouselItem> CarouselItems { get; set; }
        public IList<ProductItem> ProductItems { get; set; }
    }
}
