using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_srytr.Models.Database.Entity
{
    [Table(nameof(CarouselItem))]
    public class CarouselItem
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [ContentType("Image")]
        [NotMapped]
        public IFormFile Image { get; set; }


        [StringLength(255)]
        [Required]
        public string ImageSource { get; set; }

        [StringLength(55)]
        public string ImageAlt { get; set; }

    }
}
