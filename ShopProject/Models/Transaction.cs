using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

namespace ShopProject.Models
{
    public class Transaction
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Paid Amount")]
        public decimal Paid { get; set; }


    }
}
