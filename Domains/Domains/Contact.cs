using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Domains
{
    public class Contact : Base
    {
        [Required(ErrorMessage ="please enter Country")]
        public string? Country { get; set; }
        [Required(ErrorMessage = "please enter Government")]
        public string? Government { get; set; }
        [Required(ErrorMessage = "please enter City")]
        public string? City { get; set; }
        public int? EmployeeId { get; set; }
        public virtual Employees? Employee { get; set; }
        public int? CandidateId { get; set; }
        public virtual Candidates? Candidate { get; set; }
    }
}
