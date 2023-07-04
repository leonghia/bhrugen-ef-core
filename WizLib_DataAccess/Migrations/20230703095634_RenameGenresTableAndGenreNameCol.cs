using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WizLib_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenameGenresTableAndGenreNameCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "tb_Genres");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "tb_Genres",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Genres",
                table: "tb_Genres",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Genres",
                table: "tb_Genres");

            migrationBuilder.RenameTable(
                name: "tb_Genres",
                newName: "Genres");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genres",
                newName: "GenreName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreId");
        }
    }
}
