using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class baiasm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "9a1311e9-720c-408d-af15-e76eb2d26966");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "3afc87d9-b32a-40bf-8b32-9aa57a5a1f84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "05d8bbdf-37dc-49d7-a545-1463c1f9037a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "364ecb93-b608-4967-86a9-5d4ee4042842", "AQAAAAEAACcQAAAAEAFDqKvDttn0q31gNojeMmvJ3vxIuMVGDxlAkNLYCaXRtHOHfJpnkpH89KGcGvAbbw==", "0e44e977-9e8d-40be-bfa8-7541fc6f9dd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "684ec516-c02d-4635-a3cc-accae2efff21", "AQAAAAEAACcQAAAAEHMDhCjaP1Dr+F3SWHVMXBEchKKfVDLt4z6AstelGWD7QA+Qztlkr66kqfeeD7XUYQ==", "b14144d9-487d-41cd-8669-7bafb21dcaa4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5141f623-bbbd-4818-997d-3076665698bf", "AQAAAAEAACcQAAAAEAS6A1nOzLVMDu0f7LINX6KKK7MU2QqsB5wVCw8il4JX01yhanCZUHbOuDgr3hhG1g==", "35bb41ce-23fb-4703-a8cd-babee36e6f1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd309948-80ba-4060-b7f5-2833a4d24a21", "AQAAAAEAACcQAAAAEMP1cQLrpqunMOS8ogB/c+65DOI4CmvbU8X+dfq4Di0aMwKP1/WRWCLjy9KXfeKIgg==", "7a629cdd-6b6c-4b45-920f-e3811356396b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "76dac72a-6ecf-46a5-b736-b35ecbbc86a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "f011a62e-732f-41d9-a993-e97a0d572dc0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "ac308c29-217f-4c6f-a91e-a1bba3596b44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "110f7c82-2aac-4237-95a0-1c745bc28c24", "AQAAAAEAACcQAAAAEEduJM0QT64Rb1oAnF7sCABQm9bDilqxLlLNfDZHs4rAe33fZHOqrkpV0rgKQNWGgQ==", "4acdc27f-4211-49cf-bdd6-08e241e40947" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a57b6a2-85ca-494d-9eb2-70606f1ff888", "AQAAAAEAACcQAAAAEDsjMedS/y6CnF4L7I8m1Pq4t+fArvtNS88lqFbKVtgOV89K2YijUjrRNbhBr7sURw==", "2f051ba5-d68b-4c89-8219-275374558481" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ada33846-8411-45cb-a00d-7dd2a8aebd7c", "AQAAAAEAACcQAAAAENtszrFc8xRmpybBtwHkCgoq1ppNRWYsfwenS1nERcjDtal2TfSuq1TIvUgp5GZcfQ==", "adb08521-d781-46e0-8911-30bf3b167ba2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "630abdcd-bb3d-4e64-a6b5-e7576cb1dc90", "AQAAAAEAACcQAAAAEM0Y+14nKqpxz8i7KBm81Ml/Ule6ld5+HZY05yAbQQN41DcZsbPn1aeqM8odFSM6Cg==", "24a40cbf-9cca-46ac-9a13-58904ed7c0f5" });
        }
    }
}
