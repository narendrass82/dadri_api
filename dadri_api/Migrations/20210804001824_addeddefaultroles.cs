using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dadri_api.Migrations
{
    public partial class addeddefaultroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "UserLogin");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Mobile",
                table: "User",
                newName: "IX_User_Mobile");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "User",
                newName: "IX_User_Email");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserId_URoleId",
                table: "UserRole",
                newName: "IX_UserRole_UserId_URoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogin",
                newName: "IX_UserLogin_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                columns: new[] { "UserId", "URoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin",
                column: "UserId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "181c5a2d-514c-4cf6-8b0f-24bcbfd24403", "964db67e-5d5c-4eaa-a1a7-86fd5b30eafd", "User", "USER" },
                    { "3ed16947-a1b3-4c0a-ae2c-446a0de1e767", "61e4a40d-0517-4872-b6f2-d28fce7518e0", "Dsm", "DSM" },
                    { "5f0bd33a-b95d-4610-87e4-5a7151e90e3c", "27230a3b-254f-43be-87d5-f57110cd347a", "MovieAdmin", "MOVIEADMIN" },
                    { "3cfb23ae-3cb6-4f11-8ede-75aa2708c630", "adae60c4-acba-4cf5-88df-24c60e837a92", "Movie", "MOVIE" },
                    { "3114da27-d4a6-45e0-b873-28d5cc984c0d", "7723cb33-fb8a-4e1c-91b4-a878741b2ff0", "HospitalAdmin", "HOSPITALADMIN" },
                    { "7e5ceeb8-262a-4250-8075-e233ce1ac71d", "8db7e235-6a39-435f-b4a8-825c8151115c", "BusWalletAdmin", "BUSWALLETADMIN" },
                    { "e4791609-aa87-4cfd-9391-d36f5a3b14ce", "17f5277a-10de-4284-9668-80318d46f0c9", "BusWallet", "BUSWALLET" },
                    { "93591552-28d0-4b96-be38-a38023e91dd1", "6049ad68-17b7-40ce-9375-61a8a2deff3e", "BusConductor", "BUSCONDUCTOR" },
                    { "9a9fa3c8-274d-483e-ae66-7968a783bf28", "d97990e7-2dd9-4cbb-922c-6e0065910851", "Bus", "BUS" },
                    { "0a523944-ab6f-4636-88bf-5cf927a13843", "98c16781-89f7-4ed7-8dfa-4c44d6017d0e", "WelfareVrc", "WELFAREVRC" },
                    { "3ed1fca2-ea3c-44e4-a952-18f0d5bc70af", "c1270c01-48b1-45e5-a618-22940d2cf545", "WelfareNtpcClubAdmin", "WELFARENTPCCLUBADMIN" },
                    { "0a692dd4-702f-42e0-96e8-464822e7f224", "d2c3f4e0-c004-4939-9dfb-834c942514e4", "WelfareNtpcClub", "WELFARENTPCCLUB" },
                    { "0f84f316-f393-48fb-b99a-33c02a04bc24", "385ddb28-be2a-4153-9da9-b75c69d4f6c7", "Welfare", "WELFARE" },
                    { "d5634682-059f-44d1-8ba7-808da33e1bca", "2f62299c-1b44-4905-968d-50ed90a27d4d", "SasAdmin", "SASADMIN" },
                    { "eb8c7299-9ff5-418d-91fc-d86df9b6cfab", "779202a9-e0c7-4637-941b-dd589b7f2e6b", "Sas", "SAS" },
                    { "8490a035-9b6c-400d-8a26-38714b9f889c", "b98f4360-f58e-4464-a0e6-18dfa8478844", "Administrator", "ADMINISTRATOR" },
                    { "4536acd7-efd1-475f-963c-837268b0d3f7", "10aaba34-2797-4663-9588-8d4b1888e952", "WelfareVrcAdmin", "WELFAREVRCADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "RegistratinDate" },
                values: new object[] { new DateTime(2021, 8, 4, 5, 48, 24, 166, DateTimeKind.Local).AddTicks(7515), new DateTime(2021, 8, 4, 5, 48, 24, 166, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "UserRegisters",
                keyColumn: "RegisterId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "RegistratinDate" },
                values: new object[] { new DateTime(2021, 8, 4, 5, 48, 24, 165, DateTimeKind.Local).AddTicks(2771), new DateTime(2021, 8, 4, 5, 48, 24, 166, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_User_UserId",
                table: "UserLogin",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_User_UserId",
                table: "UserLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a523944-ab6f-4636-88bf-5cf927a13843");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a692dd4-702f-42e0-96e8-464822e7f224");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f84f316-f393-48fb-b99a-33c02a04bc24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "181c5a2d-514c-4cf6-8b0f-24bcbfd24403");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3114da27-d4a6-45e0-b873-28d5cc984c0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cfb23ae-3cb6-4f11-8ede-75aa2708c630");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ed16947-a1b3-4c0a-ae2c-446a0de1e767");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ed1fca2-ea3c-44e4-a952-18f0d5bc70af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4536acd7-efd1-475f-963c-837268b0d3f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f0bd33a-b95d-4610-87e4-5a7151e90e3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e5ceeb8-262a-4250-8075-e233ce1ac71d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8490a035-9b6c-400d-8a26-38714b9f889c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93591552-28d0-4b96-be38-a38023e91dd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a9fa3c8-274d-483e-ae66-7968a783bf28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5634682-059f-44d1-8ba7-808da33e1bca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4791609-aa87-4cfd-9391-d36f5a3b14ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb8c7299-9ff5-418d-91fc-d86df9b6cfab");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogin",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_UserId_URoleId",
                table: "UserRoles",
                newName: "IX_UserRoles_UserId_URoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogin_UserId",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Mobile",
                table: "Users",
                newName: "IX_Users_Mobile");

            migrationBuilder.RenameIndex(
                name: "IX_User_Email",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "UserId", "URoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.UpdateData(
                table: "UserRegisters",
                keyColumn: "RegisterId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "RegistratinDate" },
                values: new object[] { new DateTime(2021, 8, 3, 10, 5, 24, 185, DateTimeKind.Local).AddTicks(9364), new DateTime(2021, 8, 3, 10, 5, 24, 187, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "RegistratinDate" },
                values: new object[] { new DateTime(2021, 8, 3, 10, 5, 24, 187, DateTimeKind.Local).AddTicks(4788), new DateTime(2021, 8, 3, 10, 5, 24, 187, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
