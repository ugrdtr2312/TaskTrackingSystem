using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Manytomanytablenamechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProject");

            migrationBuilder.CreateTable(
                name: "UsersProjects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersProjects", x => new { x.ProjectId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UsersProjects_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 13, 10, 54, 952, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Deadline",
                value: new DateTime(2021, 6, 3, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Deadline",
                value: new DateTime(2021, 6, 4, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Deadline",
                value: new DateTime(2021, 6, 7, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Deadline",
                value: new DateTime(2021, 6, 3, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 13, 10, 54, 955, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.InsertData(
                table: "UsersProjects",
                columns: new[] { "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 3, 1 },
                    { 2, 3 },
                    { 2, 2 },
                    { 2, 1 },
                    { 1, 3 },
                    { 1, 2 },
                    { 3, 3 },
                    { 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersProjects_UserId",
                table: "UsersProjects",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersProjects");

            migrationBuilder.CreateTable(
                name: "UserProject",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProject", x => new { x.ProjectId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserProject_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProject_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "59c24955-a469-4c67-a4a8-2911b22fce44");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f5876f4a-4558-44d6-8de3-87fa1bbc52b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "333179e6-9668-4571-aec3-45d2626ae6a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c908388-4394-41df-90a8-d1d59ce66aea", "AQAAAAEAACcQAAAAELvkcjyDCdJHoMZ6C14BiH5EP6PUzyoYg/xIgxL91KkKr85LGQBXcEHMMI6kJ6FTpw==", "367eb21f-b499-45ee-a596-c834da8121c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4330ae7a-0696-47fa-a1c8-d88462376601", "AQAAAAEAACcQAAAAEJZrVJ6Ma/8pjNpBjh3DKwZkNO0C6yoYUxhLizwF9NzLMmvCiT+F1mfmlJ/EzJEF5w==", "d2946575-9004-4bb9-b11a-333c3db1bf75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c241cfd-9661-4da2-abce-959cba35666b", "AQAAAAEAACcQAAAAEJnywSRN42MlFs+3wzI7+U9d/X6azm1UKGFUam8FewNAv1zJJOBJmi4hbYVwFNdglA==", "beec1df3-db36-4a36-ae16-495d512d713a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d83f52d-b225-41e7-b2d7-2bf61b3f8f26", "AQAAAAEAACcQAAAAEOZO+n7JYc+mFwxmosut4ylI2oP/mSowLh2E0+OCtDIFKJLUfkAGIFwK+cSbVX+CmA==", "f2418e35-35cb-4d6f-a6b5-ebaac4d3f85e" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 12, 53, 39, 88, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Deadline",
                value: new DateTime(2021, 6, 3, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Deadline",
                value: new DateTime(2021, 6, 4, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Deadline",
                value: new DateTime(2021, 6, 7, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Deadline",
                value: new DateTime(2021, 6, 3, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 12, 53, 39, 90, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.InsertData(
                table: "UserProject",
                columns: new[] { "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 3, 1 },
                    { 2, 3 },
                    { 2, 2 },
                    { 2, 1 },
                    { 1, 3 },
                    { 1, 2 },
                    { 3, 3 },
                    { 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProject_UserId",
                table: "UserProject",
                column: "UserId");
        }
    }
}
