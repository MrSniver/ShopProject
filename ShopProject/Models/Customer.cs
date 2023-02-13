using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ShopProject.Models
{
    public class Customer
    {
        [Required]
        [Display(Name = "Customer Id")]
        public int ID { get; set; }
        [StringLength(30, MinimumLength = 2)]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }
        [StringLength(30, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string CustomerLastName { get; set; }
        public bool IsPatron { get; set; }


    }
}
