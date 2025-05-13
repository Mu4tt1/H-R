using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using H_R.Models;

namespace H_R.Models
{
    [Table("BookCategories")]
    public class BookCategory
    {
        [Key]
        [Display(Name = "Book-Category ID")]
        public int BookCategoryId { get; set; }

        [ForeignKey("BookId")]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }

        [Display(Name = "Book")]
        public Book Book { get; set; }

        [ForeignKey("CategoryId")]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        [Display(Name = "Category")]
        public Category Category { get; set; }
    }
}