using dadri_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Configurations.Entities
{
    public class UserEmployerConfiguration : IEntityTypeConfiguration<UserEmployer>
    {
        public void Configure(EntityTypeBuilder<UserEmployer> builder)
        {
            builder.HasData(
                new UserEmployer
                {
                    EmployerId = 1,
                    EmployerName = "NTPC Ltd",
                    TypeId = 1
                }, new UserEmployer
                {

                    EmployerId = 2,
                    EmployerName = "CISF",
                    TypeId = 1
                }, new UserEmployer
                {
                    EmployerId = 3,
                    EmployerName = "UPL",
                    TypeId = 1
                }, new UserEmployer
                {
                    EmployerId = 4,
                    EmployerName = "BHEL",
                    TypeId = 1
                }, new UserEmployer
                {
                    EmployerId = 5,
                    EmployerName = "Gail",
                    TypeId = 1
                }, new UserEmployer
                {
                    EmployerId = 6,
                    EmployerName = "Power Grid",
                    TypeId = 1
                }, new UserEmployer
                {
                    EmployerId = 7,
                    EmployerName = "DPS",
                    TypeId = 1
                }, new UserEmployer
                {
                    EmployerId = 8,
                    EmployerName = "KV",
                    TypeId = 1
                }, new UserEmployer
                {
                    EmployerId = 9,
                    EmployerName = "DAV",
                    TypeId = 1
                }, new UserEmployer
                {
                    EmployerId = 10,
                    EmployerName = "Others",
                    TypeId = 1
                });
        }
    }
}
