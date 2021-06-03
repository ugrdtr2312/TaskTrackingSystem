using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class TaskEmployeerenamedtoTaskUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetUsers_EmployeeId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Tasks",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_EmployeeId",
                table: "Tasks",
                newName: "IX_Tasks_UserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ee53d2c9-6d3f-401b-b596-c436e66c44b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "71580b31-9d26-4807-b8c9-76e58ef97e1b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4c0f9a3f-cc5b-48b7-a1d7-6d446065cbe6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7d96405-e666-4e8e-8e5f-0c5eac1f70d6", "AQAAAAEAACcQAAAAEIDxKI1D+ruPw/tn9QLdkFIhZM27JAUF3xywRRJxM6fdxtlQyLLfeQ7UuRt6gAHMaw==", "87f15177-8808-4d1f-88fc-a4ee8a8b8c3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2fdb2c5-7358-4438-80ca-c41d91a74328", "AQAAAAEAACcQAAAAEMwMnVT+f6Q4cUcJokWftjk0EY2+wbw82fQfGu+CJ39ffhAxJiuuJX7FVB640tOYQw==", "86da9f1d-b2c6-40c4-a9c2-b6a58cc89d81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e2c326e-a6ab-4f77-a225-4980964cf51d", "AQAAAAEAACcQAAAAEMhiP50mvLm3VQ/RbMm/fuHlg8E5+730KqT3mc7Ls8g/CkDBjqsKNBZ3M9E13ayY8w==", "8b9a1730-d8cd-40b2-865c-e74453101c09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "659e7079-efb4-431c-9f72-60d0adff286e", "AQAAAAEAACcQAAAAEMjOTxMuuI+PmbFMIJpY7BHe2MZ+iYDh5EzPOeFpbiQBu1bxa3R41u2GNqeMpRLFSw==", "16f4c40b-75e0-4820-a406-ddcf48f34b78" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 19, 51, 50, 40, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Deadline",
                value: new DateTime(2021, 6, 3, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Deadline",
                value: new DateTime(2021, 6, 4, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Deadline",
                value: new DateTime(2021, 6, 7, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Deadline",
                value: new DateTime(2021, 6, 3, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 19, 51, 50, 43, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetUsers_UserId",
                table: "Tasks",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetUsers_UserId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tasks",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                newName: "IX_Tasks_EmployeeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "06901cf2-f288-4cc2-98b9-94f782409f31");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1ef2f6a6-290e-4093-be59-995c0675f048");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "fe8a2444-1870-4af4-9ed1-0a2aacb7b55d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f9d48a3-2ca2-448c-bad8-30253085afff", "AQAAAAEAACcQAAAAENppII7OwI5k4/BlCmxmBFZ7lsiHr7ugJKYjS4SsFiLWlQf61NcgHHJaMdTzLCCsbw==", "e824911c-aeef-424c-a314-716f9165ea5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea7ec956-ac50-4f10-9303-18329a12c415", "AQAAAAEAACcQAAAAEAdnz16GHpmwK/l9LC6yzY4fNkyHTWjtB9XnRMhOBt/XeKaWe0mTWGDWRPqfx32kDQ==", "608a72ca-efc8-4eb9-a826-1d054e78e6a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1627b9b2-0542-43ca-98eb-ebd20923abd7", "AQAAAAEAACcQAAAAEBY7IIVnmgNxutEBHSLAmUWZG9DlxH5izqTlGTIVi7o16Wgj3b1E9UQB/T+qdOKucw==", "81bad552-ec95-4f79-8127-689717f22dd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88280a85-3eb4-4cd1-93f3-5b40cca12970", "AQAAAAEAACcQAAAAEAWDZgdPb3rrVDSyEfPIq7NUQRpz8PS1k8SgiVW9m7KqlfhowKhRhziFtolCiktACQ==", "cda0de19-fcc1-4774-a904-c23daae1c293" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 18, 49, 29, 466, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Deadline",
                value: new DateTime(2021, 6, 3, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Deadline",
                value: new DateTime(2021, 6, 4, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Deadline",
                value: new DateTime(2021, 6, 7, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Deadline",
                value: new DateTime(2021, 6, 3, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetUsers_EmployeeId",
                table: "Tasks",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
