using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Dataseederadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectUser");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "d02238b3-1305-4ba8-81b4-43a7f9a488fe", "Admin", "ADMIN" },
                    { 2, "4c326d61-e278-468c-a417-e621840a8a58", "Manager", "MANAGER" },
                    { 3, "977a0de8-2162-4159-9287-c58a07057168", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "822fd2d2-334a-45d4-bb92-f5965f6f9613", "vladimir231200@gmail.com", true, "Vladimir", false, null, "VLADIMIR231200@GMAIL.COM", "UGRDTR", "AQAAAAEAACcQAAAAEMUqILva7tSHFjN9V3HXIaHjN0yFs20uPQ2GLpHHhN1YItS5HmwMhkzrulXJ8gpoIQ==", null, false, "fabd7d76-3e57-4ef9-8884-632daf138fa2", "Shengeliya", false, "ugrdtr" },
                    { 2, 0, "f6df0488-8815-4917-b989-a7f473420216", "ns18091@gmail.com", true, "Nikita", false, null, "NS18091@GMAIL.COM", "MXXNR1SE", "AQAAAAEAACcQAAAAEG4KvjpnHVIFreQ8O49cmBpAwtimjMKc4u3Q7X4p5epPGFJhqzHsPmJZMRUWGmPwbw==", null, false, "9686ae33-aac3-4be0-b5ee-115836ccecfa", "Sidorov", false, "mxxnr1se" },
                    { 3, 0, "4d9f5367-540b-4c0a-8e29-fc5751560b7d", "kochka4real@gmail.com", true, "Danila", false, null, "KOCHKA4REAL@GMAIL.COM", "AOLAN13", "AQAAAAEAACcQAAAAEKjzOg/kDkkuF1hToCFFCIk6hucUz76Ty/vkEcyUMv/33N3bdNOhy32oGRfwPdFSog==", null, false, "b2a7261a-94ed-4e02-8446-f6bef256dddd", "Crazy", false, "Aolan13" },
                    { 4, 0, "d91388c6-15b1-4e76-9ec5-3ce4b8e326d7", "janglaide@gmail.com", true, "Alison", false, null, "JANGLAIDE@GMAIL.COM", "JANGLAIDE", "AQAAAAEAACcQAAAAEKBlDikykpTUmgwMNZ+IGOCZwey7FzLAirYLU8oAyB5b2RpFAdu0KxJElkMEax05eA==", null, false, "f27ba729-121b-4dd1-af24-23f2a0db87d6", "Proshchenko", false, "janglaide" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Web project 1 description", "Web project 1" },
                    { 2, "Web project 2 description", "Web project 2" },
                    { 3, "Web project 3 description", "Web project 3" }
                });

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 2, 3 },
                    { 1, 4 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Deadline", "Description", "EmployeeId", "LastUpdate", "Name", "ProjectId", "TaskPriorityId", "TaskStatusId" },
                values: new object[,]
                {
                    { 11, new DateTime(2021, 6, 8, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1782), "Task11 description", 2, null, "Task11", 1, 2, 4 },
                    { 9, new DateTime(2021, 6, 3, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1776), "Task9 description", 2, null, "Task9", 1, 4, 2 },
                    { 8, new DateTime(2021, 6, 7, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1773), "Task8 description", 2, null, "Task8", 1, 4, 1 },
                    { 5, new DateTime(2021, 6, 4, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1764), "Task5 description", 2, null, "Task5", 1, 1, 1 },
                    { 6, new DateTime(2021, 6, 6, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1767), "Task6 description", 2, null, "Task6", 1, 3, 3 },
                    { 12, new DateTime(2021, 6, 6, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1785), "Task12 description", 1, null, "Task12", 1, 3, 2 },
                    { 10, new DateTime(2021, 6, 5, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1779), "Task10 description", 1, null, "Task10", 1, 1, 5 },
                    { 7, new DateTime(2021, 6, 5, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1770), "Task7 description", 1, null, "Task7", 1, 2, 1 },
                    { 4, new DateTime(2021, 6, 8, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1761), "Task4 description", 1, null, "Task4", 1, 2, 2 },
                    { 3, new DateTime(2021, 6, 3, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1756), "Task3 description", 1, null, "Task3", 1, 3, 3 },
                    { 2, new DateTime(2021, 6, 6, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1727), "Task2 description", 1, null, "Task2", 1, 1, 2 },
                    { 1, new DateTime(2021, 6, 5, 12, 45, 22, 338, DateTimeKind.Local).AddTicks(9517), "Task1 description", 1, null, "Task1", 1, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserProject",
                columns: new[] { "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProject_UserId",
                table: "UserProject",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProject");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskPriority",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskPriority",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaskPriority",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskPriority",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ProjectsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => new { x.ProjectsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ProjectUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_UsersId",
                table: "ProjectUser",
                column: "UsersId");
        }
    }
}
