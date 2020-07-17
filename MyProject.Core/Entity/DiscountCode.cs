using MyProject.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject.Core.Entity
{
    [Table("SHOP.DiscountCode")]
    public class DiscountCode : Entity<byte>
    {
        public string Code { get; set; }
        public string Discount { get; set; }
        public bool Active { get; set; }
    }
}
