using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KarateClases.Server.Migrations
{
    /// <inheritdoc />
    public partial class conDojo_Tutor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tutor",
                table: "Alumnos",
                newName: "TutorId");

            migrationBuilder.RenameColumn(
                name: "Dojo",
                table: "Alumnos",
                newName: "DojoId");

            migrationBuilder.CreateTable(
                name: "Dojos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dojos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tutores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ocupacion = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TutorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutores_Tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_DojoId",
                table: "Alumnos",
                column: "DojoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_TutorId",
                table: "Alumnos",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutores_TutorId",
                table: "Tutores",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Dojos_DojoId",
                table: "Alumnos",
                column: "DojoId",
                principalTable: "Dojos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Tutores_TutorId",
                table: "Alumnos",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Dojos_DojoId",
                table: "Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Tutores_TutorId",
                table: "Alumnos");

            migrationBuilder.DropTable(
                name: "Dojos");

            migrationBuilder.DropTable(
                name: "Tutores");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_DojoId",
                table: "Alumnos");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_TutorId",
                table: "Alumnos");

            migrationBuilder.RenameColumn(
                name: "TutorId",
                table: "Alumnos",
                newName: "Tutor");

            migrationBuilder.RenameColumn(
                name: "DojoId",
                table: "Alumnos",
                newName: "Dojo");
        }
    }
}
