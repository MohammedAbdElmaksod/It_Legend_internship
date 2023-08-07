using Domains.Domains;
using System.Net.Http.Headers;

namespace Domains
{
    public class Employees : Base
    {
        public string? fullName { get; set; }
        public string? email { get; set; }
        public string? phoneNumber { get; set; }
        public string? imgUrl { get; set; }
        public string? userId { get; set; } = null!;
        public DateTime? foundedDate { get; set; }
        public string? location { get; set; }
        public string? businessEmail { get; set; }
        public string? services { get; set; }
        public string? companySize { get; set; }
        public string? aboutCompany { get; set; }
        public int? socialMediaId { get; set; }
        public int? categoryId { get; set; }
        public int? jobId { get; set; }
        public int? companyCategoriesId { get; set; }
        public virtual Categories? Categories { get; set; }
        public virtual SocialMedia? SocialMedia { get; set; }
        public virtual Jobs? Jobs { get; set; }
        public virtual CompanyCategories? companyCategories { get; set; }
    }
}
