using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChallengeLN.Migrations
{
    /// <inheritdoc />
    public partial class ChallengeLN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    Empresa = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Imagen = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false, defaultValueSql: "('')"),
                    DomicilioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Contacto__3214EC274B87E835", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Domicilio",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    Ciudad = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('')"),
                    ContactoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Domicilio__3214EC27BCC346F7", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contacto_Domicilio",
                        column: x => x.ContactoId,
                        principalTable: "Contacto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Domicilio_ContactoId",
                table: "Domicilio",
                column: "ContactoId",
                unique: true,
                filter: "[ContactoId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Domicilio");

            migrationBuilder.DropTable(
                name: "Contacto");
        }
    }
}
