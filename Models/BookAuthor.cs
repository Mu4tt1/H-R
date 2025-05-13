using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H_R.Models
{
    [Table("BookAuthors")]
    public class BookAuthor
    {
        [Key]
        [Display(Name = "Book-Author ID")]
        public int BookAuthorId { get; set; }

        [ForeignKey("BookId")]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }

        [Display(Name = "Book")]
        public Book Book { get; set; }

        [ForeignKey("AuthorId")]
        [Display(Name = "Author ID")]
        public int AuthorId { get; set; }

        [Display(Name = "Author")]
        public Author Author { get; set; }
    }
}