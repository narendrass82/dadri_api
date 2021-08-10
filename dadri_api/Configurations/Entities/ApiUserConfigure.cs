using dadri_api.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Configurations.Entities
{
    
    public class ApiUserConfigure : IEntityTypeConfiguration<ApiUser>
    {
        
        public void Configure(EntityTypeBuilder<ApiUser> builder)
        {            
            var user = new ApiUser
            {
                Id= "315fd140-825a-4ed6-9c6a-c69f31d1bbb3",
                PhoneNumber = "1234567890",
                Email = "super@ntpc.co.in",
                ApprovalDate = DateTime.Now,
                ApprovedBy = "super",                
                DOB = DateTime.Now,                
                EntryIntoGrade = DateTime.Now,
                FirstName = "Super",                
                IsApproved = true,
                LastName = "Singh",
                NTPCJoining = DateTime.Now,
                GradeId = 1,
                EmployerId = 1,
                DeptId = 1,
                PersonalAreaId=999,
                ProjectId=1011,
                UserName= "super@ntpc.co.in"
            };
            var passwordHasher = new PasswordHasher<ApiUser>();            
            user.PasswordHash = passwordHasher.HashPassword(user, "Dadri@789");
            builder.HasData(user);
        }
    }
}
