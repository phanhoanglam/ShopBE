using MyProject.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject.Core.Entity
{
    [Table("SHOP.Slides")]
    public class Slide : Entity<byte>
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public byte DisplayOrder { get; set; }
        public bool Status { get; set; }
    }
}
