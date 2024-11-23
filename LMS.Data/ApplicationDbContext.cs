using LMS.Data.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Institution> Institution { get; set; }
        public virtual DbSet<PageLink> PageLink { get; set; }
        public virtual DbSet<PageLinkAssign> PageLinkAssign { get; set; }
        public virtual DbSet<PageLinkCategory> PageLinkCategory { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new RegistrationConfiguration());
            builder.ApplyConfiguration(new PageLinkConfiguration());
            builder.ApplyConfiguration(new PageLinkAssignConfiguration());
            builder.ApplyConfiguration(new PageLinkCategoryConfiguration());
            builder.ApplyConfiguration(new InstitutionConfiguration());

            base.OnModelCreating(builder);
            builder.SeedInsitutionData();
            builder.SeedAdminData();
            //builder.SeedSubAdminLinkData();
        }
    }
}