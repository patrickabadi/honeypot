using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace honeypot.server.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeletedEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EntityId = table.Column<Guid>(nullable: false),
                    DataType = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletedEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    First = table.Column<string>(maxLength: 256, nullable: true),
                    Last = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeletedEntities_EntityId_DataType",
                table: "DeletedEntities",
                columns: new[] { "EntityId", "DataType" },
                unique: true,
                filter: "[DataType] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeletedEntities");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
