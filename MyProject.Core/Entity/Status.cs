using MyProject.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject.Core.Entity
{
    [Table("SHOP.Status")]
    public class Status : Entity<byte>
    {
        public string Name { get; set; }
    }
}
