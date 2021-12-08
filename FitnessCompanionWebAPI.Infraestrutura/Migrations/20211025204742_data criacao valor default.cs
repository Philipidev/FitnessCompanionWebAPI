using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FitnessCompanionWebAPI.Infraestrutura.Migrations
{
    public partial class datacriacaovalordefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("7b797696-1cd5-4753-801d-b25bd3472246"));

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuario",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "Atividade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Treino",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeLocal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duracao = table.Column<int>(type: "int", nullable: false),
                    AtividadeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treino", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treino_Atividade_AtividadeId",
                        column: x => x.AtividadeId,
                        principalTable: "Atividade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "DataExclusao", "Email", "Nome", "Senha", "Sobrenome" },
                values: new object[] { new Guid("3eba1da2-8c67-4f1f-8634-885811557b7b"), null, new DateTime(2021, 10, 25, 17, 47, 41, 637, DateTimeKind.Local).AddTicks(4582), null, "philipi.altoe@gmail.com", "Philipi", "123", "Carvalho" });

            migrationBuilder.CreateIndex(
                name: "IX_Treino_AtividadeId",
                table: "Treino",
                column: "AtividadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Treino");

            migrationBuilder.DropTable(
                name: "Atividade");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("3eba1da2-8c67-4f1f-8634-885811557b7b"));

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuario",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "DataExclusao", "Email", "Nome", "Senha", "Sobrenome" },
                values: new object[] { new Guid("7b797696-1cd5-4753-801d-b25bd3472246"), null, new DateTime(2021, 10, 21, 21, 8, 59, 62, DateTimeKind.Local).AddTicks(9558), null, "philipi.altoe@gmail.com", "Philipi", "123", "Carvalho" });
        }
    }
}
