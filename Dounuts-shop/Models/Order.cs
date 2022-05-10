using Dounuts_shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donuts_shop.Models
{
    public class Order
    {
        [BindNever]
        [Key]
        public int OrderId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "Your name is too long")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your last name is required.")]
        [StringLength(16, ErrorMessage = "Last name is too long.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email doesn't look like a valid email address.")]
        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Email")]
        [Display(Name = "Confirm your email address")]
        public string EmailConfirm { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}