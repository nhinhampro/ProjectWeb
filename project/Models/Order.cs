using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        public string Customer { get; set; }
        
        public string Address { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int OrderStock { get; set; }

        [Required]
        public int TotalPrice { get; set; }

        [Required]
        public int BookId { get; set; }


        public Book Book { get; set; }
    }
}

