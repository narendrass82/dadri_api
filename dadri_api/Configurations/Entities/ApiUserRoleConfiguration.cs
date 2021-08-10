using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Configurations.Entities
{
    public class ApiUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "62a7ffd0-c6ca-4b3b-aeea-6bcbb9b8c848",
                    UserId = "315fd140-825a-4ed6-9c6a-c69f31d1bbb3"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "a04c2463-f4d8-4615-b423-e351b1788e42",
                    UserId = "315fd140-825a-4ed6-9c6a-c69f31d1bbb3"
                }, new IdentityUserRole<string>()
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "315fd140-825a-4ed6-9c6a-c69f31d1bbb3"
                });
        }
    }
}
