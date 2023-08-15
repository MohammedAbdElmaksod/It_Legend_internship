using Domains.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.ViewModels
{
    public class EmployeeVm : Base
    {
        public string? logoUrl { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage ="please enter company name")]
        public string? companyName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "please enter business Email")]
        public string? businessEmail { get; set; }

        [MaxLength(11)]
        [Required(ErrorMessage ="please enter the phone number")]
        public string? phoneNumber { get; set; }

        public string? webSiteUrl { get; set; }

        [Required(ErrorMessage ="plase enter the founded date")]
        public DateTime? foundedDate { get; set; }

        [Required(ErrorMessage ="please enter the company size")]
        public int? companySize { get; set; }

        [Required(ErrorMessage ="please choose category")]
        public List<Categories>? lstCategories { get; set; }

        public string? introVideoUrl { get; set; }

        [MaxLength(500)]
        [Required(ErrorMessage ="please enter description about your company")]
        public string? aboutCompany { get; set; }

        public SocialMedia? social { get; set; }

        [Required(ErrorMessage ="please enter the contact information for your company")]
        public Contact? contactInfo { get; set; }

        public string? userId { get; set; }

        public string? location { get; set; }

        public string? services { get; set; }

        public string? email { get; set; }

        [Required(ErrorMessage ="choose category please")]
        public int? categoryId { get; set; }
    }
}
