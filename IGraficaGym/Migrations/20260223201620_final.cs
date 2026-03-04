using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IGraficaGym.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonitoresFuncionarios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnyoIngresoCuerpo = table.Column<int>(type: "int", nullable: false),
                    DestinoDefinitivo = table.Column<bool>(type: "bit", nullable: false),
                    TipoMedico = table.Column<long>(type: "bigint", nullable: false),
                    RutaFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoMonitor = table.Column<long>(type: "bigint", nullable: false),
                    Especializacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitoresFuncionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonitoresExtendidos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Estatura = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    MonitorGymPublicoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ECivil = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitoresExtendidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitoresExtendidos_MonitoresFuncionarios_MonitorGymPublicoId",
                        column: x => x.MonitorGymPublicoId,
                        principalTable: "MonitoresFuncionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonitoresExtendidos_MonitorGymPublicoId",
                table: "MonitoresExtendidos",
                column: "MonitorGymPublicoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonitoresExtendidos");

            migrationBuilder.DropTable(
                name: "MonitoresFuncionarios");
        }
    }
}
