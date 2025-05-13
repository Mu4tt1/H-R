using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_R.Models
{
    [Table("Authors")]
    public class Author
    {
        [Key]
        [Display(Name = "Author ID")]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Author Name")]
        public string Name { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        [Display(Name = "Books")]
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}