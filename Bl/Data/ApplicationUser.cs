using Microsoft.AspNetCore.Identity;
using Domains;

namespace Bl.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public string? countryCode { get; set; } = null!;
        public bool AcceptedTerms { get; set; }
        public virtual Employees? employees { get; set; }
        public virtual Candidates? candidates { get; set; }
    }
}

