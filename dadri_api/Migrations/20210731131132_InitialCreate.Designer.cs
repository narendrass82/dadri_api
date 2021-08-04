﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dadri_api.Data;

namespace dadri_api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210731131132_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dadri_api.Data.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "Jamaica",
                            ShortName = "JM"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "Bahamas",
                            ShortName = "BS"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "Cayman Island",
                            ShortName = "CI"
                        });
                });

            modelBuilder.Entity("dadri_api.Data.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("HotelId");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            HotelId = 1,
                            Address = "America",
                            CountryId = 1,
                            Name = "America Resort and Spa",
                            Rating = 4.0999999999999996
                        },
                        new
                        {
                            HotelId = 2,
                            Address = "Negril",
                            CountryId = 3,
                            Name = "Sandels Resort and Spa",
                            Rating = 3.5
                        },
                        new
                        {
                            HotelId = 3,
                            Address = "Nassual",
                            CountryId = 3,
                            Name = "Grand Palldium",
                            Rating = 4.5
                        });
                });

            modelBuilder.Entity("dadri_api.Data.TownshipQuarter", b =>
                {
                    b.Property<int>("QuarterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Isoccupied")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OccupiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuarterCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuarterDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("QuarterId");

                    b.ToTable("TownshipQuarters");
                });

            modelBuilder.Entity("dadri_api.Data.TownshipQuarterArchive", b =>
                {
                    b.Property<int>("QuarterAId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Isoccupied")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OccupiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuarterCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuarterDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuarterId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VacatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("QuarterAId");

                    b.ToTable("TownshipQuarterArchives");
                });

            modelBuilder.Entity("dadri_api.Data.TypeIndicator", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("TypeIndicators");

                    b.HasData(
                        new
                        {
                            TypeId = 1,
                            TypeDescription = "LAN Insert"
                        },
                        new
                        {
                            TypeId = 2,
                            TypeDescription = "LAN Update"
                        },
                        new
                        {
                            TypeId = 3,
                            TypeDescription = "LAN Delete"
                        },
                        new
                        {
                            TypeId = 4,
                            TypeDescription = "WAN Insert"
                        },
                        new
                        {
                            TypeId = 5,
                            TypeDescription = "WAN Update"
                        },
                        new
                        {
                            TypeId = 6,
                            TypeDescription = "Do Nothing"
                        });
                });

            modelBuilder.Entity("dadri_api.Data.URole", b =>
                {
                    b.Property<int>("URoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("RoleCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("URoleId");

                    b.ToTable("URoles");

                    b.HasData(
                        new
                        {
                            URoleId = 1,
                            IsDefault = false,
                            RoleDescription = "Registration Approval",
                            TypeId = 1
                        },
                        new
                        {
                            URoleId = 2,
                            IsDefault = true,
                            RoleDescription = "Login",
                            TypeId = 1
                        },
                        new
                        {
                            URoleId = 3,
                            IsDefault = false,
                            RoleDescription = "Login Approval",
                            TypeId = 1
                        });
                });

            modelBuilder.Entity("dadri_api.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApprovalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EntryIntoGrade")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<string>("IntercomH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntercomH2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntercomO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntercomO2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Mobile2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NTPCJoining")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonalAreaId")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePathImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectCodeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProjectJoining")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuarterId")
                        .HasColumnType("int");

                    b.Property<int>("QuarterId2")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistratinDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("Mobile")
                        .IsUnique()
                        .HasFilter("[Mobile] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ApprovalDate = new DateTime(2021, 7, 31, 18, 41, 31, 977, DateTimeKind.Local).AddTicks(5744),
                            ApprovedBy = "009392",
                            DOB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptId = 0,
                            Email = "narendrasingh@ntpc.co.in",
                            EmpNo = "009392",
                            EmployerId = 1,
                            EntryIntoGrade = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Narendra",
                            GradeId = 0,
                            IsActive = true,
                            IsApproved = true,
                            LastName = "Singh",
                            Mobile = "8527500155",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NTPCJoining = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonalAreaId = 0,
                            ProjectCodeId = 0,
                            ProjectJoining = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuarterId = 0,
                            QuarterId2 = 0,
                            RegistratinDate = new DateTime(2021, 7, 31, 18, 41, 31, 977, DateTimeKind.Local).AddTicks(7447),
                            TypeId = 0
                        });
                });

            modelBuilder.Entity("dadri_api.Data.UserDept", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("DeptId");

                    b.HasIndex("GroupId");

                    b.ToTable("UserDepts");
                });

            modelBuilder.Entity("dadri_api.Data.UserDeptGroup", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("GroupId");

                    b.ToTable("UserDeptGroups");
                });

            modelBuilder.Entity("dadri_api.Data.UserEmployer", b =>
                {
                    b.Property<int>("EmployerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("EmployerId");

                    b.ToTable("UserEmployers");

                    b.HasData(
                        new
                        {
                            EmployerId = 1,
                            EmployerName = "NTPC Ltd",
                            TypeId = 1
                        },
                        new
                        {
                            EmployerId = 2,
                            EmployerName = "CISF",
                            TypeId = 1
                        },
                        new
                        {
                            EmployerId = 3,
                            EmployerName = "UPL",
                            TypeId = 1
                        },
                        new
                        {
                            EmployerId = 4,
                            EmployerName = "BHEL",
                            TypeId = 1
                        },
                        new
                        {
                            EmployerId = 5,
                            EmployerName = "Gail",
                            TypeId = 1
                        },
                        new
                        {
                            EmployerId = 6,
                            EmployerName = "Power Grid",
                            TypeId = 1
                        },
                        new
                        {
                            EmployerId = 7,
                            EmployerName = "DPS",
                            TypeId = 1
                        },
                        new
                        {
                            EmployerId = 8,
                            EmployerName = "KV",
                            TypeId = 1
                        },
                        new
                        {
                            EmployerId = 9,
                            EmployerName = "DAV",
                            TypeId = 1
                        },
                        new
                        {
                            EmployerId = 10,
                            EmployerName = "Others",
                            TypeId = 1
                        });
                });

            modelBuilder.Entity("dadri_api.Data.UserGrade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GradeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GradeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("GradeId");

                    b.ToTable("UserGrades");
                });

            modelBuilder.Entity("dadri_api.Data.UserLogin", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DeviceIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceMac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Otp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OtpGenerateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OtpTemp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TokenId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("dadri_api.Data.UserPersonalArea", b =>
                {
                    b.Property<int>("PersonalAreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonalAreaCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalAreaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("PersonalAreaId");

                    b.ToTable("UserPersonalAreas");
                });

            modelBuilder.Entity("dadri_api.Data.UserProject", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId");

                    b.ToTable("UserProjects");
                });

            modelBuilder.Entity("dadri_api.Data.UserRegister", b =>
                {
                    b.Property<int>("RegisterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApprovalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistratinDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("RegisterId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("EmployerId");

                    b.HasIndex("Mobile")
                        .IsUnique()
                        .HasFilter("[Mobile] IS NOT NULL");

                    b.ToTable("UserRegisters");

                    b.HasData(
                        new
                        {
                            RegisterId = 1,
                            ApprovalDate = new DateTime(2021, 7, 31, 18, 41, 31, 975, DateTimeKind.Local).AddTicks(9905),
                            ApprovedBy = "009392",
                            Email = "narendrasingh@ntpc.co.in",
                            EmployerId = 1,
                            FirstName = "Narendra",
                            IsApproved = true,
                            LastName = "Singh",
                            Mobile = "8527500155",
                            ProjectId = 0,
                            RegistratinDate = new DateTime(2021, 7, 31, 18, 41, 31, 977, DateTimeKind.Local).AddTicks(3882)
                        });
                });

            modelBuilder.Entity("dadri_api.Data.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("URoleId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "URoleId");

                    b.HasIndex("UserId", "URoleId")
                        .IsUnique();

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("dadri_api.Data.Hotel", b =>
                {
                    b.HasOne("dadri_api.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("dadri_api.Data.UserDept", b =>
                {
                    b.HasOne("dadri_api.Data.UserDeptGroup", "UserDeptGroup")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDeptGroup");
                });

            modelBuilder.Entity("dadri_api.Data.UserLogin", b =>
                {
                    b.HasOne("dadri_api.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("dadri_api.Data.UserRegister", b =>
                {
                    b.HasOne("dadri_api.Data.UserEmployer", "UserEmployer")
                        .WithMany()
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserEmployer");
                });

            modelBuilder.Entity("dadri_api.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}