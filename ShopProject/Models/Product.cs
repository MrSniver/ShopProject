using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ShopProject.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 2)]
        public string ProductName { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Product's cost")]
        public decimal Price { get; set; }


    }
}
