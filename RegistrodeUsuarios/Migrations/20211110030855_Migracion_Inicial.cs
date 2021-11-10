using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrodeUsuarios.Migrations
{
    public partial class Migracion_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Usuarioid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    NombreDeUsuario = table.Column<string>(type: "TEXT", nullable: true),
                    Contrasena = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Usuarioid);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Usuarioid", "Apellidos", "Contrasena", "NombreDeUsuario", "Nombres" },
                values: new object[] { 1, "Diaz", "cffa965d9faa1d453f2d336294b029a7f84f485f75ce2a2c723065453b12b03b", "profesor", "Reny" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
