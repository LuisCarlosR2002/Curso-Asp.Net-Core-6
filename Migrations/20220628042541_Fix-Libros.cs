using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAutores.Migrations
{
    public partial class FixLibros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Autores_AutorId1",
                table: "Libros");

            migrationBuilder.DropIndex(
                name: "IX_Libros_AutorId1",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "AutorId1",
                table: "Libros");

            migrationBuilder.AlterColumn<int>(
                name: "AutorId",
                table: "Libros",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdAutor",
                table: "Libros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Libros_AutorId",
                table: "Libros",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Autores_AutorId",
                table: "Libros",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Autores_AutorId",
                table: "Libros");

            migrationBuilder.DropIndex(
                name: "IX_Libros_AutorId",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "IdAutor",
                table: "Libros");

            migrationBuilder.AlterColumn<string>(
                name: "AutorId",
                table: "Libros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutorId1",
                table: "Libros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Libros_AutorId1",
                table: "Libros",
                column: "AutorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Autores_AutorId1",
                table: "Libros",
                column: "AutorId1",
                principalTable: "Autores",
                principalColumn: "Id");
        }
    }
}
