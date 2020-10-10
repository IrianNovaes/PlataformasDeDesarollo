using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParcialPDD.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioPK = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Usuario = table.Column<string>(maxLength: 20, nullable: true),
                    Clave = table.Column<string>(type: "char(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioPK);
                });

            migrationBuilder.CreateTable(
                name: "Recursos",
                columns: table => new
                {
                    RecursoPK = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(maxLength: 50, nullable: true),
                    UsuarioPK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recursos", x => x.RecursoPK);
                    table.ForeignKey(
                        name: "FK_Recursos_Usuarios_UsuarioPK",
                        column: x => x.UsuarioPK,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioPK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    TareaPK = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(maxLength: 100, nullable: true),
                    Vencimiento = table.Column<DateTime>(nullable: false),
                    Estimacion = table.Column<int>(nullable: false),
                    ResponsableRecursoPK = table.Column<int>(nullable: true),
                    Estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.TareaPK);
                    table.ForeignKey(
                        name: "FK_Tareas_Recursos_ResponsableRecursoPK",
                        column: x => x.ResponsableRecursoPK,
                        principalTable: "Recursos",
                        principalColumn: "RecursoPK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalles",
                columns: table => new
                {
                    DetallePK = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Tiempo = table.Column<int>(nullable: false),
                    RecursoPK = table.Column<int>(nullable: true),
                    TareaPK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles", x => x.DetallePK);
                    table.ForeignKey(
                        name: "FK_Detalles_Recursos_RecursoPK",
                        column: x => x.RecursoPK,
                        principalTable: "Recursos",
                        principalColumn: "RecursoPK",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalles_Tareas_TareaPK",
                        column: x => x.TareaPK,
                        principalTable: "Tareas",
                        principalColumn: "TareaPK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_RecursoPK",
                table: "Detalles",
                column: "RecursoPK");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_TareaPK",
                table: "Detalles",
                column: "TareaPK");

            migrationBuilder.CreateIndex(
                name: "IX_Recursos_UsuarioPK",
                table: "Recursos",
                column: "UsuarioPK");

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_ResponsableRecursoPK",
                table: "Tareas",
                column: "ResponsableRecursoPK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalles");

            migrationBuilder.DropTable(
                name: "Tareas");

            migrationBuilder.DropTable(
                name: "Recursos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
