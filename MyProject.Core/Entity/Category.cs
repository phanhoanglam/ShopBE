using MyProject.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MyProject.Core.Entity
{
    [Table("SHOP.Categories")]
    public class Category : Entity<long>
    {
        public string Name { get; set; }
        public string Metatitle { get; set; }
        [AllowNull]
        public long? ParentId { get; set; }
        public byte DisplayOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool Status { get; set; }
        public string PathImage { get; set; }
        public bool ShowHome { get; set; }
    }
}
