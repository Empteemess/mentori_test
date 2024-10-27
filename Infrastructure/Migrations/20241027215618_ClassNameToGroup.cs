using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ClassNameToGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClasses",
                table: "UserClasses");

            migrationBuilder.DropColumn(
                name: "Hours",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "days",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Classes",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClasses",
                table: "UserClasses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekDay = table.Column<int>(type: "int", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => new { x.GroupId, x.Id });
                    table.ForeignKey(
                        name: "FK_Days_Classes_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserClasses_UserId_classesId",
                table: "UserClasses",
                columns: new[] { "UserId", "classesId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClasses",
                table: "UserClasses");

            migrationBuilder.DropIndex(
                name: "IX_UserClasses_UserId_classesId",
                table: "UserClasses");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AddColumn<string>(
                name: "Hours",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "days",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClasses",
                table: "UserClasses",
                columns: new[] { "UserId", "classesId" });
        }
    }
}
