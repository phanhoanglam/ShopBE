using MyProject.Core.Abstract;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Core.Entity
{
    [Table("SHOP.Products")]
    public class Product : Entity<long>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public long CategoryId { get; set; }
        public string Metatitle { get; set; }
        public double Price { get; set; }
        public double PromotionPrice { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool Status { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}