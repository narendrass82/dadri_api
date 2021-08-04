using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Configurations.Entities
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name="User",
                    NormalizedName="USER"
                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
                , new IdentityRole
                {
                    Name = "Sas",
                    NormalizedName = "SAS"
                }, new IdentityRole
                {
                    Name = "SasAdmin",
                    NormalizedName = "SASADMIN"
                }, new IdentityRole
                {
                    Name = "Welfare",
                    NormalizedName = "WELFARE"
                }, new IdentityRole
                {
                    Name = "WelfareNtpcClub",
                    NormalizedName = "WELFARENTPCCLUB"
                }, new IdentityRole
                {
                    Name = "WelfareNtpcClubAdmin",
                    NormalizedName = "WELFARENTPCCLUBADMIN"
                }
                , new IdentityRole
                {
                    Name = "WelfareVrc",
                    NormalizedName = "WELFAREVRC"
                }, new IdentityRole
                {
                    Name = "WelfareVrcAdmin",
                    NormalizedName = "WELFAREVRCADMIN"
                }, new IdentityRole
                {
                    Name = "Bus",
                    NormalizedName = "BUS"
                }, new IdentityRole
                {
                    Name = "BusConductor",
                    NormalizedName = "BUSCONDUCTOR"
                }, new IdentityRole
                {
                    Name = "BusWallet",
                    NormalizedName = "BUSWALLET"
                }, new IdentityRole
                {
                    Name = "BusWalletAdmin",
                    NormalizedName = "BUSWALLETADMIN"
                }, new IdentityRole
                {
                    Name = "HospitalAdmin",
                    NormalizedName = "HOSPITALADMIN"
                }, new IdentityRole
                {
                    Name = "Movie",
                    NormalizedName = "MOVIE"
                }, new IdentityRole
                {
                    Name = "MovieAdmin",
                    NormalizedName = "MOVIEADMIN"
                }, new IdentityRole
                {
                    Name = "Dsm",
                    NormalizedName = "DSM"
                });
        }
    }
}
