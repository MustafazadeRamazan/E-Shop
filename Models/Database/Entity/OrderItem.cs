using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using eshop_srytr.Models.Database.Entity;

namespace eshop_srytr.Models.Entity
{
    [Table(nameof(OrderItem))]
    public class OrderItem
    {

        [Key]
        [Required]
        public int ID { get; set; }

        [ForeignKey(nameof(Order))]
        public int OrderID { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductID { get; set; }

        public int Amount { get; set; }
        public double Price { get; set; }

        public Order Order { get; set; }
        public ProductItem Product { get; set; }
    }
}
