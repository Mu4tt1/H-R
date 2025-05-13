using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using H_R.Models;

namespace H_R.Models
{
    [Table("Subscriptions")]
    public class Subscription
    {
        [Key]
        [Display(Name = "Subscription ID")]
        public int SubscriptionId { get; set; }

        [Required]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "Plan ID")]
        public int PlanId { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "User")]
        public User User { get; set; }

        [Display(Name = "Subscription Plan")]
        public Plan Plan { get; set; }
    }
}
