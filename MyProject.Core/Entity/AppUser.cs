using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Core.Entity
{
    [Table("SHOP.AppUser")]
    public class AppUser : IdentityUser
    {
        public string Address { get; set; }
        public bool Gender { get; set; }
        public bool Active { get; set; }
    }
}