using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FitnessCompanionWebAPI.Infraestrutura.Migrations
{
    public partial class tabelasiniciaisesuasinteracoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("3eba1da2-8c67-4f1f-8634-885811557b7b"));

            migrationBuilder.AddColumn<double>(
                name: "Avaliacao",
                table: "Usuario",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sobre",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeLocal",
                table: "Treino",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Duracao",
                table: "Treino",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Treino",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Atividade",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Atividade",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Avatar", "DataAtualizacao", "DataCriacao", "DataExclusao", "Email", "Nome", "Senha", "Sobre", "Sobrenome" },
                values: new object[] { new Guid("24a5e110-2e78-45a2-9798-434af13336ed"), null, null, new DateTime(2021, 10, 25, 18, 3, 36, 405, DateTimeKind.Local).AddTicks(6488), null, "philipi.altoe@gmail.com", "Philipi", "123", null, "Carvalho" });

            migrationBuilder.CreateIndex(
                name: "IX_Treino_UsuarioId",
                table: "Treino",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_UsuarioId",
                table: "Atividade",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atividade_Usuario_UsuarioId",
                table: "Atividade",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Treino_Usuario_UsuarioId",
                table: "Treino",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atividade_Usuario_UsuarioId",
                table: "Atividade");

            migrationBuilder.DropForeignKey(
                name: "FK_Treino_Usuario_UsuarioId",
                table: "Treino");

            migrationBuilder.DropIndex(
                name: "IX_Treino_UsuarioId",
                table: "Treino");

            migrationBuilder.DropIndex(
                name: "IX_Atividade_UsuarioId",
                table: "Atividade");

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("24a5e110-2e78-45a2-9798-434af13336ed"));

            migrationBuilder.DropColumn(
                name: "Avaliacao",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Sobre",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Treino");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Atividade");

            migrationBuilder.AlterColumn<string>(
                name: "NomeLocal",
                table: "Treino",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Duracao",
                table: "Treino",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Atividade",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "DataExclusao", "Email", "Nome", "Senha", "Sobrenome" },
                values: new object[] { new Guid("3eba1da2-8c67-4f1f-8634-885811557b7b"), null, new DateTime(2021, 10, 25, 17, 47, 41, 637, DateTimeKind.Local).AddTicks(4582), null, "philipi.altoe@gmail.com", "Philipi", "123", "Carvalho" });
        }
    }
}
