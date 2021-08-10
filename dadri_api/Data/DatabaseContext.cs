using dadri_api.Configurations.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }       
        
        public DbSet<TypeIndicator> TypeIndicators { get; set; }
        public DbSet<UserEmployer> UserEmployers { get; set; }
        public DbSet<UserDept> UserDepts { get; set; }
        public DbSet<UserDeptGroup> UserDeptGroups { get; set; }
        public DbSet<UserGrade> UserGrades { get; set; }
        public DbSet<UserPersonalArea> UserPersonalAreas { get; set; }
        public DbSet<UserProject> UserProjects { get; set; }        
        public DbSet<UserRegister> UserRegisters { get; set; }
        public DbSet<TownshipQuarter> TownshipQuarters { get; set; }
        public DbSet<TownshipQuarterArchive> TownshipQuarterArchives { get; set; }       
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(true);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.Entity<UserRole>().HasKey(k => new { k.RoleId ,k.Email});
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new TypeIndicatorConfiguration());
            builder.ApplyConfiguration(new UserEmployerConfiguration());
            builder.ApplyConfiguration(new UserProjectConfiguration());
            builder.ApplyConfiguration(new UserDeptConfiguration());
            builder.ApplyConfiguration(new UserGradeConfiguration());
            builder.ApplyConfiguration(new UserPersonalAreaConfiguration());
            builder.ApplyConfiguration(new UserRegisterConfiguration());
            builder.ApplyConfiguration(new ApiUserConfigure());
            builder.ApplyConfiguration(new ApiUserRoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new TownshipQuarterConfiguration());

            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new HotelConfiguration());
        }
    }
}
