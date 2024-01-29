using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectInstagram.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AvatartLink", "Bio", "Login" },
                values: new object[] { 2, "https://instagram.frwn2-1.fna.fbcdn.net/v/t51.2885-19/380816338_1735658720336521_8935098239096366940_n.jpg?stp=dst-jpg_s320x320&_nc_ht=instagram.frwn2-1.fna.fbcdn.net&_nc_cat=101&_nc_ohc=LGALrbRjtZUAX9Qz2YC&edm=AOQ1c0wBAAAA&ccb=7-5&oh=00_AfCC1z2l1JFGg0VHgvKribPDnUweNqAiZ7NV-5ylG-_FQA&oe=65B9E56A&_nc_sid=8b3546", "University student", "dgmnkk" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccountId", "Date" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccountId", "Date" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Comment");

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3,
                column: "AccountId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4,
                column: "AccountId",
                value: 1);
        }
    }
}
