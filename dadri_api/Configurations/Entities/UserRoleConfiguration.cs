using dadri_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Configurations.Entities
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(
                new UserRole 
                { RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",Email="super@ntpc.co.in", TypeId = 1 },
                new UserRole
                { RoleId = "62a7ffd0-c6ca-4b3b-aeea-6bcbb9b8c848", Email = "super@ntpc.co.in", TypeId = 1 },
                new UserRole
                { RoleId = "a04c2463-f4d8-4615-b423-e351b1788e42", Email = "super@ntpc.co.in", TypeId = 1 }

                );
        }
    }
}
