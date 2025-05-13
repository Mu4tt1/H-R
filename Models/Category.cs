using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using H_R.Models;

namespace H_R.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        [Display(Name = "Books in this Category")]
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}