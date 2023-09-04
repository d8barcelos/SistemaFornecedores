using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFornecedores.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Fornecedores");
        }
    }
}
