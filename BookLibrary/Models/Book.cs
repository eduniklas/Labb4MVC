using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        [Required]
        [MinLength(10), MaxLength(100)]
        public string Title { get; set; } 
        [Required]
        [StringLength(300)]
        public string Description { get; set; }
        [Required]
        [MinLength(10), MaxLength(75)]
        public string Author { get; set; }
        [Required]
        public DateTime Published { get; set; }
        public virtual ICollection<LoanList> Loans { get; set; }
    }
}
