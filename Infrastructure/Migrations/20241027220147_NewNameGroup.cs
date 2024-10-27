using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewNameGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Days_Classes_GroupId",
                table: "Days");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClasses_AspNetUsers_UserId",
                table: "UserClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClasses_Classes_classesId",
                table: "UserClasses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClasses",
                table: "UserClasses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classes",
                table: "Classes");

            migrationBuilder.RenameTable(
                name: "UserClasses",
                newName: "UserGroups");

            migrationBuilder.RenameTable(
                name: "Classes",
                newName: "Groups");

            migrationBuilder.RenameIndex(
                name: "IX_UserClasses_UserId_classesId",
                table: "UserGroups",
                newName: "IX_UserGroups_UserId_classesId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClasses_classesId",
                table: "UserGroups",
                newName: "IX_UserGroups_classesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserGroups",
                table: "UserGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Groups_GroupId",
                table: "Days",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroups_AspNetUsers_UserId",
                table: "UserGroups",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroups_Groups_classesId",
                table: "UserGroups",
                column: "classesId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Days_Groups_GroupId",
                table: "Days");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGroups_AspNetUsers_UserId",
                table: "UserGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGroups_Groups_classesId",
                table: "UserGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserGroups",
                table: "UserGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "UserGroups",
                newName: "UserClasses");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Classes");

            migrationBuilder.RenameIndex(
                name: "IX_UserGroups_UserId_classesId",
                table: "UserClasses",
                newName: "IX_UserClasses_UserId_classesId");

            migrationBuilder.RenameIndex(
                name: "IX_UserGroups_classesId",
                table: "UserClasses",
                newName: "IX_UserClasses_classesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClasses",
                table: "UserClasses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classes",
                table: "Classes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Classes_GroupId",
                table: "Days",
                column: "GroupId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClasses_AspNetUsers_UserId",
                table: "UserClasses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClasses_Classes_classesId",
                table: "UserClasses",
                column: "classesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
