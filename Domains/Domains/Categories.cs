using System.ComponentModel.DataAnnotations;

namespace Domains
{
    public class Categories : Base
    {
        [Required(ErrorMessage = "please enter category")]
        [MaxLength(100)]
        public string? CategoryName { get; set; } = null!;
        public virtual List<Employees>? Employees { get; set; }
        public virtual List<Candidates>?Candidates { get; set;}
        public virtual List<Jobs>? Jobs { get; set;}
    }
}
