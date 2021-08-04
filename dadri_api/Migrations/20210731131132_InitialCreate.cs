using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dadri_api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "TownshipQuarterArchives",
                columns: table => new
                {
                    QuarterAId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuarterId = table.Column<int>(type: "int", nullable: false),
                    QuarterDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuarterCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isoccupied = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OccupiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VacatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TownshipQuarterArchives", x => x.QuarterAId);
                });

            migrationBuilder.CreateTable(
                name: "TownshipQuarters",
                columns: table => new
                {
                    QuarterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuarterDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuarterCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isoccupied = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OccupiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TownshipQuarters", x => x.QuarterId);
                });

            migrationBuilder.CreateTable(
                name: "TypeIndicators",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeIndicators", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "URoles",
                columns: table => new
                {
                    URoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URoles", x => x.URoleId);
                });

            migrationBuilder.CreateTable(
                name: "UserDeptGroups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDeptGroups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "UserEmployers",
                columns: table => new
                {
                    EmployerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEmployers", x => x.EmployerId);
                });

            migrationBuilder.CreateTable(
                name: "UserGrades",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGrades", x => x.GradeId);
                });

            migrationBuilder.CreateTable(
                name: "UserPersonalAreas",
                columns: table => new
                {
                    PersonalAreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalAreaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPersonalAreas", x => x.PersonalAreaId);
                });

            migrationBuilder.CreateTable(
                name: "UserProjects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProjects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    URoleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.URoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntercomH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntercomO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntercomH2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntercomO2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NTPCJoining = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectJoining = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryIntoGrade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    ProjectCodeId = table.Column<int>(type: "int", nullable: false),
                    PersonalAreaId = table.Column<int>(type: "int", nullable: false),
                    ProfilePathImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuarterId = table.Column<int>(type: "int", nullable: false),
                    QuarterId2 = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistratinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                    table.ForeignKey(
                        name: "FK_Hotels_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDepts",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDepts", x => x.DeptId);
                    table.ForeignKey(
                        name: "FK_UserDepts_UserDeptGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "UserDeptGroups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRegisters",
                columns: table => new
                {
                    RegisterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistratinDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    EmployerId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRegisters", x => x.RegisterId);
                    table.ForeignKey(
                        name: "FK_UserRegisters_UserEmployers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "UserEmployers",
                        principalColumn: "EmployerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Otp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtpTemp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtpGenerateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeviceIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceMac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "Jamaica", "JM" },
                    { 2, "Bahamas", "BS" },
                    { 3, "Cayman Island", "CI" }
                });

            migrationBuilder.InsertData(
                table: "TypeIndicators",
                columns: new[] { "TypeId", "TypeDescription" },
                values: new object[,]
                {
                    { 1, "LAN Insert" },
                    { 2, "LAN Update" },
                    { 3, "LAN Delete" },
                    { 4, "WAN Insert" },
                    { 5, "WAN Update" },
                    { 6, "Do Nothing" }
                });

            migrationBuilder.InsertData(
                table: "URoles",
                columns: new[] { "URoleId", "IsDefault", "RoleCode", "RoleDescription", "TypeId" },
                values: new object[,]
                {
                    { 2, true, null, "Login", 1 },
                    { 3, false, null, "Login Approval", 1 },
                    { 1, false, null, "Registration Approval", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserEmployers",
                columns: new[] { "EmployerId", "EmployerName", "TypeId" },
                values: new object[,]
                {
                    { 9, "DAV", 1 },
                    { 1, "NTPC Ltd", 1 },
                    { 2, "CISF", 1 },
                    { 3, "UPL", 1 },
                    { 4, "BHEL", 1 },
                    { 5, "Gail", 1 },
                    { 6, "Power Grid", 1 },
                    { 7, "DPS", 1 },
                    { 8, "KV", 1 },
                    { 10, "Others", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ApprovalDate", "ApprovedBy", "DOB", "DeptId", "DeviceName", "Email", "Email2", "EmpNo", "EmployerId", "EntryIntoGrade", "FirstName", "GradeId", "IntercomH", "IntercomH2", "IntercomO", "IntercomO2", "Ip", "IsActive", "IsApproved", "LastName", "Mac", "Mobile", "Mobile2", "ModifiedBy", "ModifiedDate", "NTPCJoining", "PersonalAreaId", "ProfilePathImage", "ProjectCodeId", "ProjectJoining", "QuarterId", "QuarterId2", "RegistratinDate", "TypeId" },
                values: new object[] { 1, new DateTime(2021, 7, 31, 18, 41, 31, 977, DateTimeKind.Local).AddTicks(5744), "009392", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "narendrasingh@ntpc.co.in", null, "009392", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Narendra", 0, null, null, null, null, null, true, true, "Singh", null, "8527500155", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(2021, 7, 31, 18, 41, 31, 977, DateTimeKind.Local).AddTicks(7447), 0 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "America", 1, "America Resort and Spa", 4.0999999999999996 },
                    { 2, "Negril", 3, "Sandels Resort and Spa", 3.5 },
                    { 3, "Nassual", 3, "Grand Palldium", 4.5 }
                });

            migrationBuilder.InsertData(
                table: "UserRegisters",
                columns: new[] { "RegisterId", "ApprovalDate", "ApprovedBy", "DeviceName", "Email", "EmployerId", "FirstName", "Ip", "IsApproved", "LastName", "Mac", "Mobile", "ProjectId", "RegistratinDate" },
                values: new object[] { 1, new DateTime(2021, 7, 31, 18, 41, 31, 975, DateTimeKind.Local).AddTicks(9905), "009392", null, "narendrasingh@ntpc.co.in", 1, "Narendra", null, true, "Singh", null, "8527500155", 0, new DateTime(2021, 7, 31, 18, 41, 31, 977, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CountryId",
                table: "Hotels",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDepts_GroupId",
                table: "UserDepts",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRegisters_Email",
                table: "UserRegisters",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserRegisters_EmployerId",
                table: "UserRegisters",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRegisters_Mobile",
                table: "UserRegisters",
                column: "Mobile",
                unique: true,
                filter: "[Mobile] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId_URoleId",
                table: "UserRoles",
                columns: new[] { "UserId", "URoleId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Mobile",
                table: "Users",
                column: "Mobile",
                unique: true,
                filter: "[Mobile] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "TownshipQuarterArchives");

            migrationBuilder.DropTable(
                name: "TownshipQuarters");

            migrationBuilder.DropTable(
                name: "TypeIndicators");

            migrationBuilder.DropTable(
                name: "URoles");

            migrationBuilder.DropTable(
                name: "UserDepts");

            migrationBuilder.DropTable(
                name: "UserGrades");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserPersonalAreas");

            migrationBuilder.DropTable(
                name: "UserProjects");

            migrationBuilder.DropTable(
                name: "UserRegisters");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "UserDeptGroups");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserEmployers");
        }
    }
}
