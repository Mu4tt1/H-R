using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using H_R.Models;

namespace H_R.Models
{
    [Table("Narrators")]
    public class Narrator
    {
        [Key]
        [Display(Name = "Narrator ID")]
        public int NarratorId { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Narrator Name")]
        public string Name { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        [Display(Name = "Narrated Books")]
        public ICollection<Book> Books { get; set; }
    }
}