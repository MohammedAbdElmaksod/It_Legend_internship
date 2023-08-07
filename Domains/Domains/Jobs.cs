using Domains.Domains;

namespace Domains
{
    public class Jobs : Base
    {
        public string? title { get; set; } = null!;
        public decimal? salary { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? ExprinceYears { get; set; }
        public string? gender { get; set; } = null!;
        public string? education { get; set; } = null!;
        public string? careerLevel { get; set; } = null!;
        public string? jobLocation { get; set; } = null!;
        public string? jobDescripotion { get; set; } = null!;
        public string? jobRequirments { get; set; } = null!;
        public string? imageUrl { get; set; } = null!;
        public int? CategoryId { get; set; }
        public virtual Categories? Category { get; set; }
        public int? PrivaceyId { get; set; }
        public int? StatusId { get; set; }
        public virtual JobStatus? status { get; set; }
        public virtual JobPrivacey? privacey { get; set; }
        public int? TypeId { get; set; }
        public virtual JobType? type { get; set; }
        public int? KindId { get; set; }
        public virtual JobKind? kind { get; set; }
        public virtual List<Employees>? employee { get; set; }
    }
}
