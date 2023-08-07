namespace Domains
{
    public class Candidates : Base
    {
        public string? fullName { get; set; } = null!;
        public string? location { get; set; } = null!;
        public string? userId { get; set; } = null!;
        public string? email { get; set; } = null!;
        public string? imgUrl { get; set; } = null!;
        public decimal? salary { get; set; } = null!;
        public string? phone { get; set; } = null!;
        public string? yearsOfExprince { get; set; } = null!;
        public string? gender { get; set; } = null!;
        public string? education { get; set; } = null!;
        public string? age { get; set; } = null!;
        public string? Languge { get; set; } = null!;
        public string? skils { get; set; } = null!;
        public string? universty { get; set; } = null!;
        public int? gradutionYear { get; set; } = null!;
        public int? socialMediaId { get; set; }
        public int? categoryId { get; set; }
        public virtual Categories? Categories { get; set; }
        public virtual List<Jobs>? jobs { get; set; }
        public virtual SocialMedia? SocialMedia { get; set; }
    }
}
