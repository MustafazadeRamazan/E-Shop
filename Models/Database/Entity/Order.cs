using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using eshop_srytr.Models.Identity;

namespace eshop_srytr.Models.Entity
{
    [Table(nameof(Order))]
    public class Order
    {

        [Key]
        [Required]
        public int ID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateTimeCreated { get; protected set; }

        [StringLength(25)]
        [Required]
        public string OrderNumber { get; set; }

        [Required]
        public double TotalPrice { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }

        //[ForeignKey(nameof(OrderStatus))]
        //public int OrderStatusId { get; set; }
        //public OrderStatus OrderStatus { get; set; }

        public IList<OrderItem> OrderItems { get; set; }

    }
}
