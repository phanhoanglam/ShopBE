using MyProject.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MyProject.Core.Entity
{
    [Table("SHOP.Order")]
    public class Order : Entity<long>
    {
        [AllowNull]
        public string UserId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerNode { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateCanceled { get; set; }
        public byte StatusId { get; set; }
        [AllowNull]
        public byte? DiscountId { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }
        [ForeignKey("DiscountId")]
        public virtual DiscountCode DiscountCode { get; set; }
    }
}
