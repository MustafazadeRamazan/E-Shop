using eshop_srytr.Models.Database.Entity;
using eshop_srytr.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_srytr.Models.ViewModels
{
    public class ProductViewModel
    {
        public ProductItem ProductItem { get; set; }
        public Review Review { get; set; }
        public string state { get; set; } 

        public ProductViewModel(ProductItem product, Review review)
        {
            ProductItem = product;
            Review = review;
            state = "loaded";
        }

        public ProductViewModel() { }
    }
}
