using dadri_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Configurations.Entities
{
    public class TypeIndicatorConfiguration : IEntityTypeConfiguration<TypeIndicator>
    {
        public void Configure(EntityTypeBuilder<TypeIndicator> builder)
        {
            builder.HasData(
                new TypeIndicator
                {
                    TypeId = 1,
                    TypeDescription = "LAN Insert"
                }, new TypeIndicator
                {
                    TypeId = 2,
                    TypeDescription = "LAN Update"
                }, new TypeIndicator
                {
                    TypeId = 3,
                    TypeDescription = "LAN Delete"
                }, new TypeIndicator
                {
                    TypeId = 4,
                    TypeDescription = "WAN Insert"
                }, new TypeIndicator
                {
                    TypeId = 5,
                    TypeDescription = "WAN Update"
                }, new TypeIndicator
                {
                    TypeId = 6,
                    TypeDescription = "Do Nothing"
                });

        }
    }
}
