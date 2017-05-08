using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Texter.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    To = table.Column<string>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    From = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.To);
                    table.ForeignKey(
                        name: "FK_Messages_Contacts_ContactName",
                        column: x => x.ContactName,
                        principalTable: "Contacts",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ContactName",
                table: "Messages",
                column: "ContactName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
