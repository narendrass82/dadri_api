using dadri_api.Configurations.Entities;
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
        public DbSet<URole> URoles { get; set; }        
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
            builder.Entity<UserLogin>().HasIndex(p => new { p.UserId }).IsUnique(true);
            builder.Entity<UserLogin>().Property(c => c.UserId).ValueGeneratedOnAdd();

            builder.Entity<User>().HasIndex(p => new { p.Email }).IsUnique(true);
            builder.Entity<User>().HasIndex(p => new { p.Mobile }).IsUnique(true);
            builder.Entity<User>().Property(p => p.UserId ).ValueGeneratedOnAdd();
            

            builder.Entity<UserRegister>().HasIndex(p => new { p.Email }).IsUnique(true);
            builder.Entity<UserRegister>().HasIndex(p => new { p.Mobile }).IsUnique(true);
            builder.Entity<UserRegister>().Property(p => p.RegisterId).ValueGeneratedOnAdd();
            builder.Entity<UserRegister>().Property(s => s.RegistratinDate).HasDefaultValueSql("GETDATE()");

            builder.Entity<UserRole>().HasIndex(p => new { p.UserId,p.URoleId}).IsUnique(true);
            builder.Entity<UserRole>().HasKey(u => new{u.UserId,u.URoleId });            

            builder.Entity<TypeIndicator>().Property(c => c.TypeId).ValueGeneratedOnAdd();

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new TypeIndicatorConfiguration());
            builder.ApplyConfiguration(new UserEmployerConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new HotelConfiguration());


            
            builder.Entity<URole>().HasData(
                new URole
                {
                    URoleId=1,
                    IsDefault = false,
                    RoleDescription = "Registration Approval",
                    TypeId = 1
                }, new URole
                {

                    URoleId = 2,
                    IsDefault = true,
                    RoleDescription = "Login",
                    TypeId = 1
                }, new URole
                {
                    URoleId = 3,
                    IsDefault = false,
                    RoleDescription = "Login Approval",
                    TypeId = 1
                });
            

            builder.Entity<UserRegister>().HasData(
               new UserRegister
               {
                   RegisterId = 1,
                   FirstName = "Narendra",
                   LastName = "Singh",
                   ApprovalDate = DateTime.Now,
                   ApprovedBy = "009392",
                   Email="narendrasingh@ntpc.co.in",
                   EmployerId=1,
                   IsApproved=true,
                   Mobile="8527500155",
                   RegistratinDate=DateTime.Now
               });            
            builder.Entity<User>().HasData(
               new User
               {   
                   UserId=1,
                   FirstName = "Narendra",
                   LastName = "Singh",
                   ApprovalDate = DateTime.Now,
                   ApprovedBy = "009392",
                   Email = "narendrasingh@ntpc.co.in",
                   EmployerId = 1,
                   IsApproved = true,
                   Mobile = "8527500155",
                   RegistratinDate = DateTime.Now,
                   EmpNo="009392",
                   IsActive=true                   
               });
            
            
        }
    }
}
