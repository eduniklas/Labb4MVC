using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookLibrary.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        [MinLength(5), MaxLength(50)]
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(5), MaxLength(50)]
        [DisplayName("Last name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Registered")]
        public DateTime RegisteredDate { get; set; }
        [DisplayName("Name")]
        public string FullName => $"{FirstName} {LastName}";
        public virtual ICollection<LoanList> Loans { get; set; }
    }
}
