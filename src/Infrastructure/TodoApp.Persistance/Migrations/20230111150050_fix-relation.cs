using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class fixrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_User_OwnerUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_User_OwnerUserId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_User_OwnerUserId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_User_OwnerUserId",
                table: "Reminders");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_User_OwnerUserId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Tags_TagId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_User_OwnerUserId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TagId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TaskTags",
                columns: table => new
                {
                    TaskId = table.Column<Guid>(type: "uuid", nullable: false),
                    TagId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTags", x => new { x.TagId, x.TaskId });
                    table.ForeignKey(
                        name: "FK_TaskTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskTags_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskTags_TaskId",
                table: "TaskTags",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_OwnerUserId",
                table: "Categories",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Tasks_Id",
                table: "Locations",
                column: "Id",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Users_OwnerUserId",
                table: "Locations",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Users_OwnerUserId",
                table: "Notes",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Users_OwnerUserId",
                table: "Reminders",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Users_OwnerUserId",
                table: "Tags",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_OwnerUserId",
                table: "Tasks",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_OwnerUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Tasks_Id",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Users_OwnerUserId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Users_OwnerUserId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Users_OwnerUserId",
                table: "Reminders");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Users_OwnerUserId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_OwnerUserId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TagId",
                table: "Tasks",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_User_OwnerUserId",
                table: "Categories",
                column: "OwnerUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_User_OwnerUserId",
                table: "Locations",
                column: "OwnerUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_User_OwnerUserId",
                table: "Notes",
                column: "OwnerUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_User_OwnerUserId",
                table: "Reminders",
                column: "OwnerUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_User_OwnerUserId",
                table: "Tags",
                column: "OwnerUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Tags_TagId",
                table: "Tasks",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_User_OwnerUserId",
                table: "Tasks",
                column: "OwnerUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
