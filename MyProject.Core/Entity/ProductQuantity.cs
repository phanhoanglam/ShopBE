using MyProject.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject.Core.Entity
{
    [Table("SHOP.ProductQuantity")]
    public class ProductQuantity : Entity<long>
    {
        public long ProductId { get; set; }
        public byte SizeId { get; set; }
        public byte ColorId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("SizeId")]
        public virtual Size Size { get; set; }
        [ForeignKey("ColorId")]
        public virtual Color Color { get; set; }
    }
}
