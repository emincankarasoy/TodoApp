using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class renametasktags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagTask_Locations_TasksId",
                table: "TagTask");

            migrationBuilder.DropForeignKey(
                name: "FK_TagTask_Tags_TagsId",
                table: "TagTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagTask",
                table: "TagTask");

            migrationBuilder.RenameTable(
                name: "TagTask",
                newName: "TaskTags");

            migrationBuilder.RenameIndex(
                name: "IX_TagTask_TasksId",
                table: "TaskTags",
                newName: "IX_TaskTags_TasksId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerUserId",
                table: "Users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskTags",
                table: "TaskTags",
                columns: new[] { "TagsId", "TasksId" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_OwnerUserId",
                table: "Users",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskTags_Locations_TasksId",
                table: "TaskTags",
                column: "TasksId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskTags_Tags_TagsId",
                table: "TaskTags",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_OwnerUserId",
                table: "Users",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskTags_Locations_TasksId",
                table: "TaskTags");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskTags_Tags_TagsId",
                table: "TaskTags");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_OwnerUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_OwnerUserId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskTags",
                table: "TaskTags");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedDateTime",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "TaskTags",
                newName: "TagTask");

            migrationBuilder.RenameIndex(
                name: "IX_TaskTags_TasksId",
                table: "TagTask",
                newName: "IX_TagTask_TasksId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagTask",
                table: "TagTask",
                columns: new[] { "TagsId", "TasksId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TagTask_Locations_TasksId",
                table: "TagTask",
                column: "TasksId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagTask_Tags_TagsId",
                table: "TagTask",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
