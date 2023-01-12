using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class fixtasktagrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Tasks_Id",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Tasks_TaskId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Tasks_Id",
                table: "Reminders");

            migrationBuilder.DropForeignKey(
                name: "FK_TagTask_Tasks_TasksId",
                table: "TagTask");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.AddColumn<Guid>(
                name: "BaseTaskId",
                table: "Locations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Locations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Locations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Locations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Locations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "TagId",
                table: "Locations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Locations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CategoryId",
                table: "Locations",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Categories_CategoryId",
                table: "Locations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Locations_TaskId",
                table: "Notes",
                column: "TaskId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Locations_Id",
                table: "Reminders",
                column: "Id",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagTask_Locations_TasksId",
                table: "TagTask",
                column: "TasksId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Categories_CategoryId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Locations_TaskId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Locations_Id",
                table: "Reminders");

            migrationBuilder.DropForeignKey(
                name: "FK_TagTask_Locations_TasksId",
                table: "TagTask");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CategoryId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "BaseTaskId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Locations");

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    BaseTaskId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    TagId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_OwnerUserId",
                        column: x => x.OwnerUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CategoryId",
                table: "Tasks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_OwnerUserId",
                table: "Tasks",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Tasks_Id",
                table: "Locations",
                column: "Id",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Tasks_TaskId",
                table: "Notes",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Tasks_Id",
                table: "Reminders",
                column: "Id",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TagTask_Tasks_TasksId",
                table: "TagTask",
                column: "TasksId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
