using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_R.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Cover Image URL")]
        public string CoverImageUrl { get; set; }

        [Display(Name = "Published Date")]
        public DateTime PublishedDate { get; set; }

        [ForeignKey("CategoryId")]
        [Display(Name = "Main Category")]
        [ValidateNever]
        public int CategoryId { get; set; }

        [ForeignKey("NarratorId")]
        [Display(Name = "Narrator")]
        [ValidateNever]
        public int NarratorId { get; set; }

        [ValidateNever]
        public Category Category { get; set; }

        [ForeignKey("PublishingHouseId")]
        [Display(Name = "Publishing House")]
        [ValidateNever]
        public int PublishingHouseId { get; set; }

        [Display(Name = "Publishing House")]
        public PublishingHouse PublishingHouse { get; set; }

        [Display(Name = "Authors")]
        [ValidateNever]
        public ICollection<BookAuthor> BookAuthors { get; set; }

        [Display(Name = "Additional Categories")]
        [ValidateNever]
        public ICollection<BookCategory> BookCategories { get; set; }

        [Display(Name = "Reviews")]
        [ValidateNever]
        public ICollection<Review> Reviews { get; set; }
    }
}