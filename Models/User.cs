using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_R.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(100, ErrorMessage = "Username cannot exceed 100 characters.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password")]
        public string PasswordHash { get; set; }

        [Display(Name = "Subscriptions")]
        public ICollection<Subscription> Subscriptions { get; set; }

        [Display(Name = "Reviews")]
        public ICollection<Review> Reviews { get; set; }

        [Display(Name = "Payments")]
        public ICollection<Payment> Payments { get; set; }
    }
}