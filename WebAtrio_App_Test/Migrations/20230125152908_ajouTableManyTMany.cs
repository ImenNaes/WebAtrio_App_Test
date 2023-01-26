using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAtrioAppTest.Migrations
{
    /// <inheritdoc />
    public partial class ajouTableManyTMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonneEmplois",
                columns: table => new
                {
                    PersonneId = table.Column<int>(type: "int", nullable: false),
                    EmploiId = table.Column<int>(type: "int", nullable: false),
                    DateDebut = table.Column<DateTime>(name: "Date_Debut", type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(name: "Date_Fin", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonneEmplois", x => new { x.PersonneId, x.EmploiId });
                    table.ForeignKey(
                        name: "FK_PersonneEmplois_Emplois_EmploiId",
                        column: x => x.EmploiId,
                        principalTable: "Emplois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonneEmplois_Personnees_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personnees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonneEmplois_EmploiId",
                table: "PersonneEmplois",
                column: "EmploiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonneEmplois");
        }
    }
}
