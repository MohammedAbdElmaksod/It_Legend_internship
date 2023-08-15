using Domains;
using Domains.Domains;
using Domains.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bl.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Jobs> TbJobs { get; set; }
        public virtual DbSet<Candidates> TbCandidates { get; set; }
        public virtual DbSet<Employees> TbEmplyees { get; set; }
        public virtual DbSet<SocialMedia> TbSocila { get; set; }
        public virtual DbSet<Categories> TbCategory { get; set; }
        public virtual DbSet<JobType> TbJobType { get; set; }
        public virtual DbSet<JobPrivacey> TbJobPrivacey { get; set; }
        public virtual DbSet<JobStatus> TbJobStatus { get; set; }
        public virtual DbSet<Blogs> TbBlogs { get; set; }
        public virtual DbSet<SuccessStories> TbSuccessStories { get; set; }
        public virtual DbSet<Contact> TbContact { get; set; }
        public virtual DbSet<AppliedJobs> TbAppliedJobs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Ignore<JobsWithRlated>();
            builder.Ignore<EmployeeVm>();
        }
    }
}
