using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eshop_srytr.Models.Database.Entity;
using eshop_srytr.Models.Identity;

namespace eshop_srytr.Models.Entity
{
    [Table(nameof(Review))]
    public class Review
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateTimeCreated { get; protected set; }

        [StringLength(500)]
        [Required]
        public string ReviewComment { get; set; }

        [Required]
        public double ReviewRating { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }

        [NotMapped]
        public string UserName { get; set; }

        public bool IsVisible { get; set; }

        [ForeignKey(nameof(ProductItem))]
        public int ProductId { get; set; }
        public ProductItem Product { get; set; }
    }
}
