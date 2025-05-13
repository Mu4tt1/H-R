using H_R.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_R.Models
{
    [Table("PublishingHouses")]
    public class PublishingHouse
    {
        [Key]
        [Display(Name = "Publishing House ID")]
        public int PublishingHouseId { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Publishing House Name")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [DisplayName("Contact Email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [ValidateNever]
        [Display(Name = "Books Published")]
        public ICollection<Book> Books { get; set; }
    }
}