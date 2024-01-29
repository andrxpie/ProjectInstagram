using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectInstagram.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvatartLink",
                value: "https://i2-prod.mirror.co.uk/incoming/article11890336.ece/ALTERNATES/s1227b/Screen-Shot-2018-01-21-at-122505JPG.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvatartLink",
                value: "https://instagram.frwn2-1.fna.fbcdn.net/v/t51.2885-19/380816338_1735658720336521_8935098239096366940_n.jpg?stp=dst-jpg_s320x320&_nc_ht=instagram.frwn2-1.fna.fbcdn.net&_nc_cat=101&_nc_ohc=LGALrbRjtZUAX9Qz2YC&edm=AOQ1c0wBAAAA&ccb=7-5&oh=00_AfCC1z2l1JFGg0VHgvKribPDnUweNqAiZ7NV-5ylG-_FQA&oe=65B9E56A&_nc_sid=8b3546");
        }
    }
}
