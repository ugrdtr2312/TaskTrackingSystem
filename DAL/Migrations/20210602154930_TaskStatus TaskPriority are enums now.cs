using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class TaskStatusTaskPriorityareenumsnow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskPriority_TaskPriorityId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskStatuses_TaskStatusId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskPriority");

            migrationBuilder.DropTable(
                name: "TaskStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TaskPriorityId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TaskStatusId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskPriorityId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskStatusId",
                table: "Tasks");

            migrationBuilder.AddColumn<string>(
                name: "TaskPriority",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TaskStatus",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "Deadline", "TaskPriority" },
                values: new object[] { new DateTime(2021, 6, 5, 18, 49, 29, 466, DateTimeKind.Local).AddTicks(768), "Medium" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Deadline", "TaskStatus" },
                values: new object[] { new DateTime(2021, 6, 6, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1307), "InProgress" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Deadline", "TaskPriority", "TaskStatus" },
                values: new object[] { new DateTime(2021, 6, 3, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1387), "High", "Completed" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Deadline", "TaskPriority", "TaskStatus" },
                values: new object[] { new DateTime(2021, 6, 8, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1394), "Medium", "InProgress" });

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
                columns: new[] { "Deadline", "TaskPriority", "TaskStatus" },
                values: new object[] { new DateTime(2021, 6, 6, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1399), "High", "Completed" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Deadline", "TaskPriority" },
                values: new object[] { new DateTime(2021, 6, 5, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1403), "Medium" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Deadline", "TaskPriority" },
                values: new object[] { new DateTime(2021, 6, 7, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1406), "Critical" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Deadline", "TaskPriority", "TaskStatus" },
                values: new object[] { new DateTime(2021, 6, 3, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1409), "Critical", "InProgress" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Deadline", "TaskStatus" },
                values: new object[] { new DateTime(2021, 6, 5, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1412), "OnHold" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Deadline", "TaskPriority", "TaskStatus" },
                values: new object[] { new DateTime(2021, 6, 8, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1414), "Medium", "Cancelled" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Deadline", "TaskPriority", "TaskStatus" },
                values: new object[] { new DateTime(2021, 6, 6, 18, 49, 29, 468, DateTimeKind.Local).AddTicks(1417), "High", "InProgress" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskPriority",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskStatus",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "TaskPriorityId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaskStatusId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TaskPriority",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskPriority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStatuses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9b448227-9e14-48d5-b460-9648838d1d5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "11663594-155b-453b-8557-71b25ad49ebb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e556c1e6-087d-4781-84c5-255ce46b8113");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6546cc7-3746-4f56-b894-6c2598f75073", "AQAAAAEAACcQAAAAEJpCqii+Y1YWsygKW7BFhQFeJf4AqLisxz2b2Xg+KXbdDQDsllK8NegYXf8/6j28IQ==", "cd232102-d026-4e2c-9e75-140b4d4e8d21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e172911-0d36-4da9-993b-9d6c3146e68d", "AQAAAAEAACcQAAAAEKfIF8aBj2fPTBfebNW31smUlwmHNoqbNfQva6cmrzBOmIg8ZPQh8gWHHe6hVh+jiA==", "aa5e9e65-3db5-42e2-abfa-9d0743c2be48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a4df93a-5242-4191-a315-2bbad8baf8c0", "AQAAAAEAACcQAAAAEChJpo6omIZIPY252y/jMqvx3xEc383McPiTGlPNFd9hpYFJgIwa9VfwzU3+0hXhNw==", "def7cc85-56a1-4a62-9832-3127fa675656" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c60b801e-68b4-4714-93a0-744884fcb387", "AQAAAAEAACcQAAAAEFXK6fHWeM5VRAnl45cYAlYFVZnugJ/Mohs05Jt1rKqqkLSPuEprtZur+d9kYCDEuQ==", "61ec7803-885b-4d53-8658-141b09db7168" });

            migrationBuilder.InsertData(
                table: "TaskPriority",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Low" },
                    { 2, "Medium" },
                    { 3, "High" },
                    { 4, "Critical" }
                });

            migrationBuilder.InsertData(
                table: "TaskStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "In Progress" },
                    { 3, "Completed" },
                    { 4, "On Hold" },
                    { 5, "Cancelled" }
                });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 5, 13, 10, 54, 952, DateTimeKind.Local).AddTicks(7209), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 6, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(803), 1, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 3, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(833), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 8, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(838), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 4, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(841), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 6, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(844), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 5, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(847), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 7, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(852), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 3, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(855), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 5, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(858), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 8, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(861), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Deadline", "TaskPriorityId", "TaskStatusId" },
                values: new object[] { new DateTime(2021, 6, 6, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(864), 3, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskPriorityId",
                table: "Tasks",
                column: "TaskPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskStatusId",
                table: "Tasks",
                column: "TaskStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskPriority_TaskPriorityId",
                table: "Tasks",
                column: "TaskPriorityId",
                principalTable: "TaskPriority",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskStatuses_TaskStatusId",
                table: "Tasks",
                column: "TaskStatusId",
                principalTable: "TaskStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
