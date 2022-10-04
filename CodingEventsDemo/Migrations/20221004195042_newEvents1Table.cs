using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingEventsDemo.Migrations
{
    public partial class newEvents1Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Categories_CategoryId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_EventTags_Events_EventId",
                table: "EventTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Events1");

            migrationBuilder.RenameIndex(
                name: "IX_Events_CategoryId",
                table: "Events1",
                newName: "IX_Events1_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events1",
                table: "Events1",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events1_Categories_CategoryId",
                table: "Events1",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventTags_Events1_EventId",
                table: "EventTags",
                column: "EventId",
                principalTable: "Events1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events1_Categories_CategoryId",
                table: "Events1");

            migrationBuilder.DropForeignKey(
                name: "FK_EventTags_Events1_EventId",
                table: "EventTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events1",
                table: "Events1");

            migrationBuilder.RenameTable(
                name: "Events1",
                newName: "Events");

            migrationBuilder.RenameIndex(
                name: "IX_Events1_CategoryId",
                table: "Events",
                newName: "IX_Events_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Categories_CategoryId",
                table: "Events",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventTags_Events_EventId",
                table: "EventTags",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
