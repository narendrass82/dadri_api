using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    CountryId = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    CountryId = 3,
                    Name = "Cayman Island",
                    ShortName = "CI"
                });
            builder.Entity<Hotel>().HasData(
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
