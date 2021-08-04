using dadri_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    HotelId = 1,
                    CountryId = 1,
                    Name = "America Resort and Spa",
                    Address = "America",
                    Rating = 4.1
                },
                new Hotel
                {
                    HotelId = 2,
                    CountryId = 3,
                    Name = "Sandels Resort and Spa",
                    Address = "Negril",
                    Rating = 3.5
                },
                new Hotel
                {
                    HotelId = 3,
                    CountryId = 3,
                    Name = "Grand Palldium",
                    Address = "Nassual",
                    Rating = 4.5
                });
        }
    }
}
