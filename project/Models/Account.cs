using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace project.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
