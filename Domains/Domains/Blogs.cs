using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Domains
{
    public class Blogs : Base
    {
        public int? CommentCount { get; set; }
        public string? imgUrl { get; set; }
        public string? title { get; set; }
        public string? shortDescription { get; set; }
        public virtual Employees? Employee { get; set; }
        public virtual Candidates? Candidate { get; set; }
        public int? employeeId { get; set; }
        public int? CandidateId { get; set; }
    }
}
