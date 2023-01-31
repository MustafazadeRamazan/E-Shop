using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eshop_srytr.Models.Entity;
using Microsoft.AspNetCore.Http;

namespace eshop_srytr.Models.Database.Entity
{
    [Table(nameof(ProductItem))]
    public class ProductItem
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        [StringLength(255)]
        [Required]
        public string ImageSource { get; set; }
        [StringLength(50)]
        public string ImageAlt { get; set; }
        [Required]
        public double Price { get; set; }
        [StringLength(1024)]
        [Required]
        public string Info { get; set; }

        public double ProductRating { get; set; }

        public IList<Review> Reviews { get; set; }
    }
}
