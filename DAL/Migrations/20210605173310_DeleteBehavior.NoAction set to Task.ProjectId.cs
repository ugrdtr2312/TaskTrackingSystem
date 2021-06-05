using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class DeleteBehaviorNoActionsettoTaskProjectId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5583cba0-c3ad-4389-b88c-71f1618d8a06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2bfb01d8-a993-4fbd-906c-e8bdb5dff33f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "59eba498-d7e5-4fe1-a916-19a80e57816b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "935edc3c-4d98-416b-8832-d231cffe78e8", "AQAAAAEAACcQAAAAEHhs1krJEZFz3QPNgXq5JYuI91r86PyZLkD03A3IxZB+wHp7uKbsDKB9ngw59Jkv5w==", "ea6cc26e-6c17-494b-b824-38497f195cc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12e67dcc-b902-4f11-b791-b96600bf4b07", "AQAAAAEAACcQAAAAEESaTLux9C4FERZk1cxk17PY61/QR01sXOtjEcfPhRdU5Sm8ja9O01aRAaZOLBQSKg==", "f57f8004-f26f-4d34-8cb7-6719595999e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5e5fed1-c09c-48b7-87b7-a99986cdb64c", "AQAAAAEAACcQAAAAEPqM7ypXjXM4iGf47t9Ts5AbkAClpCKG2wWeqO4oVXWs+EhN33RZlw4PHwR6C5T5Fw==", "63d45f0d-2de9-42ee-979c-9903ab51d88f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83af8664-8b22-4f22-a338-afb46e3516b8", "AQAAAAEAACcQAAAAEFFaj7DstOow/H9EDRxdRNoa6AookekPu3FnCZSjGC3xycY7BrwXtdC6gCC3/P1NRQ==", "c6abe7dc-90b4-4276-84bf-7f05037e284f" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 20, 33, 9, 942, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2021, 6, 9, 20, 33, 9, 945, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 20, 33, 9, 945, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Deadline",
                value: new DateTime(2021, 6, 11, 20, 33, 9, 945, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Deadline",
                value: new DateTime(2021, 6, 7, 20, 33, 9, 945, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Deadline",
                value: new DateTime(2021, 6, 9, 20, 33, 9, 945, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 20, 33, 9, 945, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Deadline",
                value: new DateTime(2021, 6, 10, 20, 33, 9, 945, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 20, 33, 9, 945, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 20, 33, 9, 945, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Deadline",
                value: new DateTime(2021, 6, 11, 20, 33, 9, 945, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Deadline",
                value: new DateTime(2021, 6, 9, 20, 33, 9, 945, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks");

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
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
