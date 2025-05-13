using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace H_R.Models
{
    [Table("Payments")]
    public class Payment
    {
        [Key]
        [Display(Name = "Payment ID")]
        public int PaymentId { get; set; }

        [ForeignKey("UserId")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [ForeignKey("PlanId")]
        [Display(Name = "Plan ID")]
        public int PlanId { get; set; }

        [Display(Name = "Payment Date")]
        public DateTime PaymentDate { get; set; }

        [Required]
        [Display(Name = "Amount Paid")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Display(Name = "Payment Status")]
        public string Status { get; set; }

        [Display(Name = "User")]
        public User User { get; set; }

        [Display(Name = "Subscription Plan")]
        public Plan Plan { get; set; }
    }
}