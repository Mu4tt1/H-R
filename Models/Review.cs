using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using H_R.Models;

namespace H_R.Models
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        [Display(Name = "Review ID")]
        public int ReviewId { get; set; }

        [ForeignKey("BookId")]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }

        [ForeignKey("UserId")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        [Display(Name = "Review Content")]
        public string Content { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [Display(Name = "Rating")]
        public int Rating { get; set; }

        [Display(Name = "Date Created")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Book")]
        public Book Book { get; set; }

        [Display(Name = "User")]
        public User User { get; set; }
    }
}