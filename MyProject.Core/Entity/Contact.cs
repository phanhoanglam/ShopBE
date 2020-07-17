using MyProject.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject.Core.Entity
{
    [Table("SHOP.Contact")]
    public class Contact : Entity<byte>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string FacbookURL { get; set; }
        public string ZaloURL { get; set; }
        public string InstagramURL { get; set; }
        public bool Status { get; set; }
    }
}
