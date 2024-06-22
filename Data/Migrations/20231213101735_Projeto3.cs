using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto.Data.Migrations
{
    /// <inheritdoc />
    public partial class Projeto3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anexo_Post_postId_Post",
                table: "Anexo");

            migrationBuilder.DropColumn(
                name: "ID_Grupo",
                table: "Pertence");

            migrationBuilder.DropColumn(
                name: "ID_Util",
                table: "Pertence");

            migrationBuilder.DropColumn(
                name: "ID_Grupo",
                table: "PedeAcesso");

            migrationBuilder.DropColumn(
                name: "ID_Util",
                table: "PedeAcesso");

            migrationBuilder.DropColumn(
                name: "ID_Grupo",
                table: "PartilhaGrupo");

            migrationBuilder.DropColumn(
                name: "ID_Post",
                table: "PartilhaGrupo");

            migrationBuilder.DropColumn(
                name: "ID_Ficheiro",
                table: "Partilha");

            migrationBuilder.DropColumn(
                name: "ID_Grupo",
                table: "Partilha");

            migrationBuilder.DropColumn(
                name: "ID_Util",
                table: "Grupo");

            migrationBuilder.DropColumn(
                name: "ID_Util",
                table: "Ficheiro");

            migrationBuilder.DropColumn(
                name: "ID_Post",
                table: "Comenta");

            migrationBuilder.DropColumn(
                name: "ID_Util",
                table: "Comenta");

            migrationBuilder.DropColumn(
                name: "Id_Post",
                table: "Anexo");

            migrationBuilder.RenameColumn(
                name: "postId_Post",
                table: "Anexo",
                newName: "PostId_Post");

            migrationBuilder.RenameIndex(
                name: "IX_Anexo_postId_Post",
                table: "Anexo",
                newName: "IX_Anexo_PostId_Post");

            migrationBuilder.AddForeignKey(
                name: "FK_Anexo_Post_PostId_Post",
                table: "Anexo",
                column: "PostId_Post",
                principalTable: "Post",
                principalColumn: "Id_Post",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anexo_Post_PostId_Post",
                table: "Anexo");

            migrationBuilder.RenameColumn(
                name: "PostId_Post",
                table: "Anexo",
                newName: "postId_Post");

            migrationBuilder.RenameIndex(
                name: "IX_Anexo_PostId_Post",
                table: "Anexo",
                newName: "IX_Anexo_postId_Post");

            migrationBuilder.AddColumn<int>(
                name: "ID_Grupo",
                table: "Pertence",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Util",
                table: "Pertence",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Grupo",
                table: "PedeAcesso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Util",
                table: "PedeAcesso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Grupo",
                table: "PartilhaGrupo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Post",
                table: "PartilhaGrupo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Ficheiro",
                table: "Partilha",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Grupo",
                table: "Partilha",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Util",
                table: "Grupo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Util",
                table: "Ficheiro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Post",
                table: "Comenta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Util",
                table: "Comenta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Post",
                table: "Anexo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Anexo_Post_postId_Post",
                table: "Anexo",
                column: "postId_Post",
                principalTable: "Post",
                principalColumn: "Id_Post",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
