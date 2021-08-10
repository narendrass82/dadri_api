using dadri_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Configurations.Entities
{
    public class UserRegisterConfiguration : IEntityTypeConfiguration<UserRegister>
    {
        public void Configure(EntityTypeBuilder<UserRegister> builder)
        {
            builder.HasIndex(p => new { p.Email }).IsUnique(true);            
            builder.Property(p => p.RegisterId).ValueGeneratedOnAdd();
            builder.Property(s => s.RegistratinDate).HasDefaultValueSql("GETDATE()");
            builder.HasData(
               new UserRegister
               {
                   RegisterId = 1,
                   Email = "super@ntpc.co.in",
                   ApprovalDate = DateTime.Now,
                   ApprovedBy = "super",
                   EmployerId = 1,
                   FirstName = "Super",
                   IsApproved = true,
                   LastName = "Singh",
                   PhoneNumber = "1234567890",
                   ProjectId=1011,
                   RegistratinDate=DateTime.Now                   
               });
        }
    }
}
