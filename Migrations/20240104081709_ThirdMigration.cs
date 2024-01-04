using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORMdoga.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eloado_Szam_SzamId",
                table: "Eloado");

            migrationBuilder.DropIndex(
                name: "IX_Eloado_SzamId",
                table: "Eloado");

            migrationBuilder.DropColumn(
                name: "SzamId",
                table: "Eloado");

            migrationBuilder.AddColumn<Guid>(
                name: "EloadoId",
                table: "Szam",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Szam_EloadoId",
                table: "Szam",
                column: "EloadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Szam_Eloado_EloadoId",
                table: "Szam",
                column: "EloadoId",
                principalTable: "Eloado",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Szam_Eloado_EloadoId",
                table: "Szam");

            migrationBuilder.DropIndex(
                name: "IX_Szam_EloadoId",
                table: "Szam");

            migrationBuilder.DropColumn(
                name: "EloadoId",
                table: "Szam");

            migrationBuilder.AddColumn<Guid>(
                name: "SzamId",
                table: "Eloado",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Eloado_SzamId",
                table: "Eloado",
                column: "SzamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eloado_Szam_SzamId",
                table: "Eloado",
                column: "SzamId",
                principalTable: "Szam",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
