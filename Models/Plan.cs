using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_R.Models
{
    [Table("Plans")]
    public class Plan
    {
        [Key]
        [Display(Name = "Plan ID")]
        public int PlanId { get; set; }

        [Required]
        [Display(Name = "Plan Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [MaxLength(300)]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Duration (in days)")]
        public int DurationInDays { get; set; }

        [Display(Name = "Subscriptions")]
        public ICollection<Subscription> Subscriptions { get; set; }
    }
}