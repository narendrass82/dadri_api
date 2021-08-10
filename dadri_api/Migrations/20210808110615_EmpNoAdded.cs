using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dadri_api.Migrations
{
    public partial class EmpNoAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "023f0684-e4ed-4233-af77-01eb12e5b3f9",
                column: "ConcurrencyStamp",
                value: "3b03195a-959e-4332-93de-30b58d31a15f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "114c241c-5bf4-476b-a563-d01c16347f43",
                column: "ConcurrencyStamp",
                value: "fbea9a8b-aa2e-4fa9-b6d0-c61f9aab67a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17768e60-b9d2-42de-b1d8-bc232e00352a",
                column: "ConcurrencyStamp",
                value: "b7f9cded-d406-4cbe-8333-3f1a12f0a4a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f76d77a-cd8f-42f4-b818-3f6436fa59ab",
                column: "ConcurrencyStamp",
                value: "ad776f28-7375-4a17-a9b8-994ae011557e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ca4de3-5ca7-4ecc-aace-8fcd21bce9fd",
                column: "ConcurrencyStamp",
                value: "6a77ffa8-927b-443a-9cab-71fa85eda1c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "806da96b-e63e-4fca-b245-fe0f9489eff1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cf03a26-2bed-4d3f-b557-0e703e771640",
                column: "ConcurrencyStamp",
                value: "822ad124-cca6-41e2-8e01-6fff8183970c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62a7ffd0-c6ca-4b3b-aeea-6bcbb9b8c848",
                column: "ConcurrencyStamp",
                value: "67d890d8-0d2b-49c0-b4c6-bb0af4f6622c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f9940a0-9984-4aad-80dc-3a3ef5f66c90",
                column: "ConcurrencyStamp",
                value: "6c6d00fe-e987-4ce9-9ba4-471221ca1790");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "715eb33f-22ed-4f64-8995-6a079665cd8e",
                column: "ConcurrencyStamp",
                value: "d148448e-ab5c-4290-b1d9-25734ff849fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76a57f2b-705b-47d1-82bb-93b4d3048e54",
                column: "ConcurrencyStamp",
                value: "91ce0450-1151-4da0-bd34-c11574c188fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fbe20a2-734c-498e-872f-e03afdbe11a1",
                column: "ConcurrencyStamp",
                value: "d1d52cc5-7986-47c7-ae89-9a1f2fd85673");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81c9ff14-99a4-42ce-9485-2357fee4cbd1",
                column: "ConcurrencyStamp",
                value: "57d34d20-5134-4596-9f1d-64c529399256");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ac95a0c-15ce-45fa-80d9-6b45e02cfb1f",
                column: "ConcurrencyStamp",
                value: "293a5e25-f0a7-400d-b9b2-c2e881087d0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d30de17-ac0c-4c89-9a36-f83605ec18b6",
                column: "ConcurrencyStamp",
                value: "871c24a1-1c0b-4e06-a7b2-3b59fd731cd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9791d714-34de-4c62-ad2a-f4bd29ab5059",
                column: "ConcurrencyStamp",
                value: "07f67847-9f65-4cee-9196-e2a30d6ced5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a04c2463-f4d8-4615-b423-e351b1788e42",
                column: "ConcurrencyStamp",
                value: "af474cf3-3ee4-482d-b5f9-51750a1eb435");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abcc56c0-6aba-4f32-9585-1322f9aa41e4",
                column: "ConcurrencyStamp",
                value: "04329189-64f9-410a-811f-40a6b2d332ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7af329b-19fe-467a-a8e0-233cbf009363",
                column: "ConcurrencyStamp",
                value: "3aacadc1-04ac-4782-bd70-a5be2d093bb8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c41af5eb-fb37-460d-937f-c644f8acedca",
                column: "ConcurrencyStamp",
                value: "b23a1d0b-45bf-4703-b91d-ca7cd4433062");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbac2059-1264-45c5-a33f-81fc2bad3d72",
                column: "ConcurrencyStamp",
                value: "71ab5f52-9367-4dab-aad1-af8c1d25c1fc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "315fd140-825a-4ed6-9c6a-c69f31d1bbb3",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "DOB", "EntryIntoGrade", "NTPCJoining", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2021, 8, 8, 16, 36, 13, 477, DateTimeKind.Local).AddTicks(4797), "5b9f5283-7e91-4a52-b4cd-21f51963d2e6", new DateTime(2021, 8, 8, 16, 36, 13, 477, DateTimeKind.Local).AddTicks(5625), new DateTime(2021, 8, 8, 16, 36, 13, 477, DateTimeKind.Local).AddTicks(5973), new DateTime(2021, 8, 8, 16, 36, 13, 477, DateTimeKind.Local).AddTicks(7162), "AQAAAAEAACcQAAAAEO9e1gObDXn1vYhFO6zK8dxom/eGYfKXUFEL2/3irv86F83lHD2OPOCPCv9be/4gvA==", "ddcfa28f-861f-434e-a0d1-5b978a03089c" });

            migrationBuilder.UpdateData(
                table: "UserRegisters",
                keyColumn: "RegisterId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "RegistratinDate" },
                values: new object[] { new DateTime(2021, 8, 8, 16, 36, 13, 475, DateTimeKind.Local).AddTicks(6219), new DateTime(2021, 8, 8, 16, 36, 13, 477, DateTimeKind.Local).AddTicks(241) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpNo",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "023f0684-e4ed-4233-af77-01eb12e5b3f9",
                column: "ConcurrencyStamp",
                value: "a5ccc92e-161d-45b5-a56f-7e8250241d22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "114c241c-5bf4-476b-a563-d01c16347f43",
                column: "ConcurrencyStamp",
                value: "da6217ea-54b0-4e2f-ab8a-4876ee1cbec9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17768e60-b9d2-42de-b1d8-bc232e00352a",
                column: "ConcurrencyStamp",
                value: "bf16edca-adcf-4ccf-9d8b-ea324fba8c94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f76d77a-cd8f-42f4-b818-3f6436fa59ab",
                column: "ConcurrencyStamp",
                value: "86054750-4cc5-4d7c-ad0f-b2f15d544ec1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ca4de3-5ca7-4ecc-aace-8fcd21bce9fd",
                column: "ConcurrencyStamp",
                value: "078e7003-bfc4-4f49-bb94-8964d5866e3d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "323a91d6-6cfe-4859-9c2a-8f80ec76dbc0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cf03a26-2bed-4d3f-b557-0e703e771640",
                column: "ConcurrencyStamp",
                value: "879664ee-54b1-44a2-b26b-373582194711");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62a7ffd0-c6ca-4b3b-aeea-6bcbb9b8c848",
                column: "ConcurrencyStamp",
                value: "3de33538-9f32-4b53-96d6-64e389591a45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f9940a0-9984-4aad-80dc-3a3ef5f66c90",
                column: "ConcurrencyStamp",
                value: "d694a66e-7c03-439b-8165-fc7872ae0413");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "715eb33f-22ed-4f64-8995-6a079665cd8e",
                column: "ConcurrencyStamp",
                value: "ed2975e8-1498-44ff-bd96-5acf2ad8b0ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76a57f2b-705b-47d1-82bb-93b4d3048e54",
                column: "ConcurrencyStamp",
                value: "039ffd6c-332b-4d67-9759-0b843d5ff85d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fbe20a2-734c-498e-872f-e03afdbe11a1",
                column: "ConcurrencyStamp",
                value: "4cb39c55-f8c6-4929-8a09-f8240d634197");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81c9ff14-99a4-42ce-9485-2357fee4cbd1",
                column: "ConcurrencyStamp",
                value: "09b4a6b5-ce0a-4f7d-abee-346d96ffee21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ac95a0c-15ce-45fa-80d9-6b45e02cfb1f",
                column: "ConcurrencyStamp",
                value: "f57ccb00-2496-4ec9-ba8c-219a112f299a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d30de17-ac0c-4c89-9a36-f83605ec18b6",
                column: "ConcurrencyStamp",
                value: "4e1ea16d-91f7-4800-8d4a-c1b5f3616040");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9791d714-34de-4c62-ad2a-f4bd29ab5059",
                column: "ConcurrencyStamp",
                value: "36df6d7e-fcd7-46ae-9bf4-218b17a3e55f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a04c2463-f4d8-4615-b423-e351b1788e42",
                column: "ConcurrencyStamp",
                value: "03b7f15a-b5b4-46c7-83ae-edaefa79dc4c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abcc56c0-6aba-4f32-9585-1322f9aa41e4",
                column: "ConcurrencyStamp",
                value: "17fd7cd5-1b63-4170-b317-62bd737e9256");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7af329b-19fe-467a-a8e0-233cbf009363",
                column: "ConcurrencyStamp",
                value: "2bf55084-cf0b-4d6f-96fe-b0da685ae8f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c41af5eb-fb37-460d-937f-c644f8acedca",
                column: "ConcurrencyStamp",
                value: "02f9a72a-081c-44c7-a63f-0a53663e8db2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbac2059-1264-45c5-a33f-81fc2bad3d72",
                column: "ConcurrencyStamp",
                value: "9678f616-dfb4-46e8-bf0c-4689491538e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "315fd140-825a-4ed6-9c6a-c69f31d1bbb3",
                columns: new[] { "ApprovalDate", "ConcurrencyStamp", "DOB", "EntryIntoGrade", "NTPCJoining", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2021, 8, 8, 12, 4, 45, 879, DateTimeKind.Local).AddTicks(3675), "f430b662-d4db-42c1-ac31-6e42740c728b", new DateTime(2021, 8, 8, 12, 4, 45, 879, DateTimeKind.Local).AddTicks(4457), new DateTime(2021, 8, 8, 12, 4, 45, 879, DateTimeKind.Local).AddTicks(4791), new DateTime(2021, 8, 8, 12, 4, 45, 879, DateTimeKind.Local).AddTicks(5935), "AQAAAAEAACcQAAAAEDKFpPW1VWGFZXFhsqA9KH2W7SpsF9JthyIcOA1SRZFAAN4l3E4WbQw+ovbe9aD0XA==", "5de1d898-2294-49b0-8c57-d0c5189d3dfa" });

            migrationBuilder.UpdateData(
                table: "UserRegisters",
                keyColumn: "RegisterId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "RegistratinDate" },
                values: new object[] { new DateTime(2021, 8, 8, 12, 4, 45, 877, DateTimeKind.Local).AddTicks(5469), new DateTime(2021, 8, 8, 12, 4, 45, 878, DateTimeKind.Local).AddTicks(9241) });
        }
    }
}
