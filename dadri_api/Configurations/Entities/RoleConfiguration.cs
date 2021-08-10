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
                    Id= "62a7ffd0-c6ca-4b3b-aeea-6bcbb9b8c848",
                    Name = "Role",
                    NormalizedName = "ROLE"
                },
                new IdentityRole
                {
                    Id = "b7af329b-19fe-467a-a8e0-233cbf009363",
                    Name ="User",
                    NormalizedName="USER"
                },
                new IdentityRole
                {
                    Id = "a04c2463-f4d8-4615-b423-e351b1788e42",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
                , new IdentityRole
                {
                    Id = "1f76d77a-cd8f-42f4-b818-3f6436fa59ab",
                    Name = "Sas",
                    NormalizedName = "SAS"
                }, new IdentityRole
                {
                    Id = "dbac2059-1264-45c5-a33f-81fc2bad3d72",
                    Name = "SasAdmin",
                    NormalizedName = "SASADMIN"
                }, new IdentityRole
                {
                    Id = "2cf03a26-2bed-4d3f-b557-0e703e771640",
                    Name = "Welfare",
                    NormalizedName = "WELFARE"
                }, new IdentityRole
                {
                    Id = "9791d714-34de-4c62-ad2a-f4bd29ab5059",
                    Name = "WelfareNtpcClub",
                    NormalizedName = "WELFARENTPCCLUB"
                }, new IdentityRole
                {
                    Id = "abcc56c0-6aba-4f32-9585-1322f9aa41e4",
                    Name = "WelfareNtpcClubAdmin",
                    NormalizedName = "WELFARENTPCCLUBADMIN"
                }
                , new IdentityRole
                {
                    Id = "76a57f2b-705b-47d1-82bb-93b4d3048e54",
                    Name = "WelfareVrc",
                    NormalizedName = "WELFAREVRC"
                }, new IdentityRole
                {
                    Id = "c41af5eb-fb37-460d-937f-c644f8acedca",
                    Name = "WelfareVrcAdmin",
                    NormalizedName = "WELFAREVRCADMIN"
                }, new IdentityRole
                {
                    Id = "7fbe20a2-734c-498e-872f-e03afdbe11a1",
                    Name = "Bus",
                    NormalizedName = "BUS"
                }, new IdentityRole
                {
                    Id = "8ac95a0c-15ce-45fa-80d9-6b45e02cfb1f",
                    Name = "BusConductor",
                    NormalizedName = "BUSCONDUCTOR"
                }, new IdentityRole
                {
                    Id = "21ca4de3-5ca7-4ecc-aace-8fcd21bce9fd",
                    Name = "BusWallet",
                    NormalizedName = "BUSWALLET"
                }, new IdentityRole
                {
                    Id = "023f0684-e4ed-4233-af77-01eb12e5b3f9",
                    Name = "BusWalletAdmin",
                    NormalizedName = "BUSWALLETADMIN"
                }, new IdentityRole
                {
                    Id = "114c241c-5bf4-476b-a563-d01c16347f43",
                    Name = "HospitalAdmin",
                    NormalizedName = "HOSPITALADMIN"
                }, new IdentityRole
                {
                    Id = "81c9ff14-99a4-42ce-9485-2357fee4cbd1",
                    Name = "Movie",
                    NormalizedName = "MOVIE"
                }, new IdentityRole
                {
                    Id = "6f9940a0-9984-4aad-80dc-3a3ef5f66c90",
                    Name = "MovieAdmin",
                    NormalizedName = "MOVIEADMIN"
                }, new IdentityRole
                {
                    Id = "715eb33f-22ed-4f64-8995-6a079665cd8e",
                    Name = "Township",
                    NormalizedName = "TOWNSHIP"
                }, new IdentityRole
                {
                    Id = "8d30de17-ac0c-4c89-9a36-f83605ec18b6",
                    Name = "TownshipAdmin",
                    NormalizedName = "TOWNSHIPADMIN"
                }, new IdentityRole
                {
                    Id = "17768e60-b9d2-42de-b1d8-bc232e00352a",
                    Name = "Dsm",
                    NormalizedName = "DSM"
                }, new IdentityRole
                {
                    Id= "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    Name = "Super",
                    NormalizedName = "SUPER"
                });
        }
    }
}
