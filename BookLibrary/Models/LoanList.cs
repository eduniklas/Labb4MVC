using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookLibrary.Models
{
    public class LoanList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanListId { get; set; }
        [ForeignKey("Customers")]
        [DisplayName("Customer")]
        public int FK_CustomerId { get; set; }
        public virtual Customer Customers { get; set; }
        [ForeignKey("Books")]
        [DisplayName("Book")]
        public int FK_BookId { get; set; }
        public virtual Book Books { get; set; }
        [Required]
        [DisplayName("Loan Date")]
        public DateTime LoanDate{ get; set; } = DateTime.Now;
        [Required]
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(31);
        public bool Returned { get; set; }
    }
}
