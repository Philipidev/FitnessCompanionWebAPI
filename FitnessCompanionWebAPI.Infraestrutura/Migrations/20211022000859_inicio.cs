using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FitnessCompanionWebAPI.Infraestrutura.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "DataExclusao", "Email", "Nome", "Senha", "Sobrenome" },
                values: new object[] { new Guid("7b797696-1cd5-4753-801d-b25bd3472246"), null, new DateTime(2021, 10, 21, 21, 8, 59, 62, DateTimeKind.Local).AddTicks(9558), null, "philipi.altoe@gmail.com", "Philipi", "123", "Carvalho" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
