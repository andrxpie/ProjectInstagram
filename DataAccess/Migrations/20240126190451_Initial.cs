using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectInstagram.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatartLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hashtags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hashtags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountAccount",
                columns: table => new
                {
                    SubscribersId = table.Column<int>(type: "int", nullable: false),
                    SubscribesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountAccount", x => new { x.SubscribersId, x.SubscribesId });
                    table.ForeignKey(
                        name: "FK_AccountAccount_Accounts_SubscribersId",
                        column: x => x.SubscribersId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountAccount_Accounts_SubscribesId",
                        column: x => x.SubscribesId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaLinks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    PostTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAdvertised = table.Column<bool>(type: "bit", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stories_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HashtagPost",
                columns: table => new
                {
                    HashtagsId = table.Column<int>(type: "int", nullable: false),
                    PostsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HashtagPost", x => new { x.HashtagsId, x.PostsId });
                    table.ForeignKey(
                        name: "FK_HashtagPost_Hashtags_HashtagsId",
                        column: x => x.HashtagsId,
                        principalTable: "Hashtags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HashtagPost_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AvatartLink", "Bio", "Login" },
                values: new object[] { 1, "https://i2-prod.mirror.co.uk/incoming/article11890336.ece/ALTERNATES/s1227b/Screen-Shot-2018-01-21-at-122505JPG.jpg", "STEP student", "andrxpie" });

            migrationBuilder.InsertData(
                table: "Hashtags",
                columns: new[] { "Id", "Likes", "Name" },
                values: new object[,]
                {
                    { 1, 0, "#ukraine" },
                    { 2, 0, "#war" },
                    { 3, 0, "#gym" },
                    { 4, 0, "#usa" },
                    { 5, 0, "#train" },
                    { 6, 0, "#nowadays" },
                    { 7, 0, "#news" },
                    { 8, 0, "#it" },
                    { 9, 0, "#programm" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AccountId", "Description", "IsAdvertised", "Likes", "MediaLinks", "PostTime" },
                values: new object[,]
                {
                    { 1, 1, "ждав покі зупиняться", true, 43, "[\"https://i.pinimg.com/564x/56/8e/6f/568e6f0325a2388fd335b4557033e568.jpg\"]", new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, "", true, 30, "[\"https://i.pinimg.com/564x/76/e6/0d/76e60df836cb6b224f4134f964681af5.jpg\"]", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, "", false, 30, "[\"https://i.pinimg.com/564x/50/7d/f3/507df3fa48c321a0aea520b3a76a0603.jpg\"]", new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "AccountId", "PostId", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, "Superoffo" },
                    { 2, 1, 1, "Poganoffo" },
                    { 3, 1, 1, "Positiffno" },
                    { 4, 1, 1, "Negatiffno" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountAccount_SubscribesId",
                table: "AccountAccount",
                column: "SubscribesId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AccountId",
                table: "Comment",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_HashtagPost_PostsId",
                table: "HashtagPost",
                column: "PostsId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AccountId",
                table: "Posts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Stories_AccountId",
                table: "Stories",
                column: "AccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountAccount");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "HashtagPost");

            migrationBuilder.DropTable(
                name: "Stories");

            migrationBuilder.DropTable(
                name: "Hashtags");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
