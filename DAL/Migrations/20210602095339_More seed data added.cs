using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Moreseeddataadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 3, 3 },
                    { 3, 2 },
                    { 3, 1 },
                    { 2, 3 },
                    { 2, 2 },
                    { 2, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserProject",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "UserProject",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "UserProject",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "UserProject",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "UserProject",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "UserProject",
                keyColumns: new[] { "ProjectId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d02238b3-1305-4ba8-81b4-43a7f9a488fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4c326d61-e278-468c-a417-e621840a8a58");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "977a0de8-2162-4159-9287-c58a07057168");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "822fd2d2-334a-45d4-bb92-f5965f6f9613", "AQAAAAEAACcQAAAAEMUqILva7tSHFjN9V3HXIaHjN0yFs20uPQ2GLpHHhN1YItS5HmwMhkzrulXJ8gpoIQ==", "fabd7d76-3e57-4ef9-8884-632daf138fa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6df0488-8815-4917-b989-a7f473420216", "AQAAAAEAACcQAAAAEG4KvjpnHVIFreQ8O49cmBpAwtimjMKc4u3Q7X4p5epPGFJhqzHsPmJZMRUWGmPwbw==", "9686ae33-aac3-4be0-b5ee-115836ccecfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d9f5367-540b-4c0a-8e29-fc5751560b7d", "AQAAAAEAACcQAAAAEKjzOg/kDkkuF1hToCFFCIk6hucUz76Ty/vkEcyUMv/33N3bdNOhy32oGRfwPdFSog==", "b2a7261a-94ed-4e02-8446-f6bef256dddd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d91388c6-15b1-4e76-9ec5-3ce4b8e326d7", "AQAAAAEAACcQAAAAEKBlDikykpTUmgwMNZ+IGOCZwey7FzLAirYLU8oAyB5b2RpFAdu0KxJElkMEax05eA==", "f27ba729-121b-4dd1-af24-23f2a0db87d6" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 12, 45, 22, 338, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Deadline",
                value: new DateTime(2021, 6, 3, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Deadline",
                value: new DateTime(2021, 6, 4, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Deadline",
                value: new DateTime(2021, 6, 7, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Deadline",
                value: new DateTime(2021, 6, 3, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Deadline",
                value: new DateTime(2021, 6, 5, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Deadline",
                value: new DateTime(2021, 6, 8, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Deadline",
                value: new DateTime(2021, 6, 6, 12, 45, 22, 341, DateTimeKind.Local).AddTicks(1785));
        }
    }
}
