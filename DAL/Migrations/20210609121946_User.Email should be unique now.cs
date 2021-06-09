using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UserEmailshouldbeuniquenow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ca165b7d-26a7-4322-bb3f-215e80f5eedc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4da49358-5276-433d-b528-df336bd7e7fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1641184b-ff86-4241-9064-aba416caa8ac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b99417c6-4b09-4f2a-840c-2a004077accc", "AQAAAAEAACcQAAAAEIYyfQIKJDiw+ISAk4evGzcyhr/xTbCz03cybKptL3KEUDlz/amW/iNM3a7R2lpEUQ==", "82c9a673-a762-4e9f-b236-c26351e9ca24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5b41f72-498f-4e1e-afe2-0f1e23863a1f", "AQAAAAEAACcQAAAAEFeEfuBbIgWcfXTdLCgn/zHq98v8EMrSUxW3WScwTCcQvA+5wUipxuFKKDaPp0kH4g==", "cf01c7be-4a64-4dc3-9eaa-7ebe948892f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3590058b-7e69-4475-b9a5-eb07a2b94c49", "AQAAAAEAACcQAAAAEKKJ/C/CVztnSj8VFVQq0D7pJgPCJDlJGlli290jVieJz+QFpIeCogmQEvVUsEZJqg==", "2cc9f79b-3b9f-46ee-be13-6394544c195d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1713a78-ea60-4256-9170-730748d4e27d", "AQAAAAEAACcQAAAAEHVdVqXW5FRqbyVnj2c+hKLLWGIgMZAw5RUkRMvxMuInhYTEn3Vj2OmH2Rzgzwq4BA==", "6533afa8-909a-459c-b323-cfda28099d1d" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2021, 6, 12, 15, 19, 45, 618, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2021, 6, 13, 15, 19, 45, 621, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Deadline",
                value: new DateTime(2021, 6, 10, 15, 19, 45, 621, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Deadline",
                value: new DateTime(2021, 6, 15, 15, 19, 45, 621, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Deadline",
                value: new DateTime(2021, 6, 11, 15, 19, 45, 621, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Deadline",
                value: new DateTime(2021, 6, 13, 15, 19, 45, 621, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Deadline",
                value: new DateTime(2021, 6, 12, 15, 19, 45, 621, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Deadline",
                value: new DateTime(2021, 6, 14, 15, 19, 45, 621, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Deadline",
                value: new DateTime(2021, 6, 10, 15, 19, 45, 621, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Deadline",
                value: new DateTime(2021, 6, 12, 15, 19, 45, 621, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Deadline",
                value: new DateTime(2021, 6, 15, 15, 19, 45, 621, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Deadline",
                value: new DateTime(2021, 6, 13, 15, 19, 45, 621, DateTimeKind.Local).AddTicks(4414));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b8c86c69-5d9d-424b-9850-afdc81c30c38");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "32d350dd-0dc2-4b6d-95f3-8ad966df2236");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "45f6eca1-06f3-491f-a4f9-bbb7da6dfa3e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28db485a-58c5-4d17-922f-565f62d7cd89", "AQAAAAEAACcQAAAAEK8MSrQ77pE79CDWexx5mIFLIH9+TWnBPsiBZoQwA2R4CIjtIhCRhvUdSYSkiXm5lw==", "93819f85-ad68-45a9-b89a-55a0218f911c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "103b4eef-f765-49e4-b279-9c97d9a2c57f", "AQAAAAEAACcQAAAAECahqnejvCvM0UW+9AzRoHpukFIo13txuwWv5LE9J4yg55ZPgSHYjfA+Du+yl3GGTQ==", "c4ba0538-e977-45fe-ad06-8c428c8aca5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "342c49e2-8704-42bb-afe7-e8ddbde90707", "AQAAAAEAACcQAAAAEG5Se7D+w9cjKKzQLpGpunUNMaIjTz7ft+36m/p8HrV1SSzEc1sXdVkLxC79BDPxFg==", "ee7916a3-67e6-402d-a5ca-bfbd9b0106e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "985c9269-7f80-4ec7-b11b-82d313c0dcff", "AQAAAAEAACcQAAAAEJA3Zp/vA1UfXKBc9JwlYDvgkdYVUjFLD8fKwBwWRub9Lh57l0S483cPd3xQC5MXKg==", "6c99d826-028a-475e-9d7a-813cca374e94" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2021, 6, 11, 19, 53, 28, 902, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2021, 6, 12, 19, 53, 28, 908, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Deadline",
                value: new DateTime(2021, 6, 9, 19, 53, 28, 908, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Deadline",
                value: new DateTime(2021, 6, 14, 19, 53, 28, 908, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Deadline",
                value: new DateTime(2021, 6, 10, 19, 53, 28, 908, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Deadline",
                value: new DateTime(2021, 6, 12, 19, 53, 28, 908, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Deadline",
                value: new DateTime(2021, 6, 11, 19, 53, 28, 908, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Deadline",
                value: new DateTime(2021, 6, 13, 19, 53, 28, 908, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Deadline",
                value: new DateTime(2021, 6, 9, 19, 53, 28, 908, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Deadline",
                value: new DateTime(2021, 6, 11, 19, 53, 28, 908, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Deadline",
                value: new DateTime(2021, 6, 14, 19, 53, 28, 908, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Deadline",
                value: new DateTime(2021, 6, 12, 19, 53, 28, 908, DateTimeKind.Local).AddTicks(1975));
        }
    }
}
