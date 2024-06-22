using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    Id_Admin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Admin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.Id_Admin);
                });

            migrationBuilder.CreateTable(
                name: "Utilizador_Autenticado",
                columns: table => new
                {
                    Id_Util = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome_Autenticado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fotografia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizador_Autenticado", x => x.Id_Util);
                });

            migrationBuilder.CreateTable(
                name: "Ficheiro",
                columns: table => new
                {
                    Id_Ficheiro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Local_Armazenamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Ficheiro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_Util = table.Column<int>(type: "int", nullable: false),
                    Utilizador_AutenticadoId_Util = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ficheiro", x => x.Id_Ficheiro);
                    table.ForeignKey(
                        name: "FK_Ficheiro_Utilizador_Autenticado_Utilizador_AutenticadoId_Util",
                        column: x => x.Utilizador_AutenticadoId_Util,
                        principalTable: "Utilizador_Autenticado",
                        principalColumn: "Id_Util");
                });

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id_Grupo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Grupo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acesso = table.Column<bool>(type: "bit", nullable: false),
                    ID_Util = table.Column<int>(type: "int", nullable: false),
                    UtilizadorId_Util = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id_Grupo);
                    table.ForeignKey(
                        name: "FK_Grupo_Utilizador_Autenticado_UtilizadorId_Util",
                        column: x => x.UtilizadorId_Util,
                        principalTable: "Utilizador_Autenticado",
                        principalColumn: "Id_Util");
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id_Post = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Post = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Texto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Visibiliade = table.Column<bool>(type: "bit", nullable: false),
                    Id_Util = table.Column<int>(type: "int", nullable: false),
                    Utilizador_AutenticadoId_Util = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id_Post);
                    table.ForeignKey(
                        name: "FK_Post_Utilizador_Autenticado_Utilizador_AutenticadoId_Util",
                        column: x => x.Utilizador_AutenticadoId_Util,
                        principalTable: "Utilizador_Autenticado",
                        principalColumn: "Id_Util");
                });

            migrationBuilder.CreateTable(
                name: "Partilha",
                columns: table => new
                {
                    ID_Partilha = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Grupo = table.Column<int>(type: "int", nullable: false),
                    ID_Ficheiro = table.Column<int>(type: "int", nullable: false),
                    GrupoId_Grupo = table.Column<int>(type: "int", nullable: false),
                    FicheiroId_Ficheiro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partilha", x => x.ID_Partilha);
                    table.ForeignKey(
                        name: "FK_Partilha_Ficheiro_FicheiroId_Ficheiro",
                        column: x => x.FicheiroId_Ficheiro,
                        principalTable: "Ficheiro",
                        principalColumn: "Id_Ficheiro"
                       );
                    table.ForeignKey(
                        name: "FK_Partilha_Grupo_GrupoId_Grupo",
                        column: x => x.GrupoId_Grupo,
                        principalTable: "Grupo",
                        principalColumn: "Id_Grupo");
                });

            migrationBuilder.CreateTable(
                name: "PedeAcesso",
                columns: table => new
                {
                    ID_PedeAcesso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Util = table.Column<int>(type: "int", nullable: false),
                    ID_Grupo = table.Column<int>(type: "int", nullable: false),
                    Data_Pedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_Resposta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resultado = table.Column<bool>(type: "bit", nullable: false),
                    UtilizadorAutenticadoId_Util = table.Column<int>(type: "int", nullable: false),
                    GrupoId_Grupo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedeAcesso", x => x.ID_PedeAcesso);
                    table.ForeignKey(
                        name: "FK_PedeAcesso_Grupo_GrupoId_Grupo",
                        column: x => x.GrupoId_Grupo,
                        principalTable: "Grupo",
                        principalColumn: "Id_Grupo");
                    table.ForeignKey(
                        name: "FK_PedeAcesso_Utilizador_Autenticado_UtilizadorAutenticadoId_Util",
                        column: x => x.UtilizadorAutenticadoId_Util,
                        principalTable: "Utilizador_Autenticado",
                        principalColumn: "Id_Util");
                });

            migrationBuilder.CreateTable(
                name: "Pertence",
                columns: table => new
                {
                    ID_Pertence = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Adesao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_Util = table.Column<int>(type: "int", nullable: false),
                    ID_Grupo = table.Column<int>(type: "int", nullable: false),
                    UtilizadorAutenticadoId_Util = table.Column<int>(type: "int", nullable: false),
                    GrupoId_Grupo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pertence", x => x.ID_Pertence);
                    table.ForeignKey(
                        name: "FK_Pertence_Grupo_GrupoId_Grupo",
                        column: x => x.GrupoId_Grupo,
                        principalTable: "Grupo",
                        principalColumn: "Id_Grupo");
                    table.ForeignKey(
                        name: "FK_Pertence_Utilizador_Autenticado_UtilizadorAutenticadoId_Util",
                        column: x => x.UtilizadorAutenticadoId_Util,
                        principalTable: "Utilizador_Autenticado",
                        principalColumn: "Id_Util");
                });

            migrationBuilder.CreateTable(
                name: "Anexo",
                columns: table => new
                {
                    Id_Anexo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Anexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL_Anexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Post = table.Column<int>(type: "int", nullable: false),
                    postId_Post = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexo", x => x.Id_Anexo);
                    table.ForeignKey(
                        name: "FK_Anexo_Post_postId_Post",
                        column: x => x.postId_Post,
                        principalTable: "Post",
                        principalColumn: "Id_Post");
                });

            migrationBuilder.CreateTable(
                name: "Comenta",
                columns: table => new
                {
                    ID_Comenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Util = table.Column<int>(type: "int", nullable: false),
                    ID_Post = table.Column<int>(type: "int", nullable: false),
                    Data_Comentario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Texto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UtilizadorAutenticadoId_Util = table.Column<int>(type: "int", nullable: false),
                    PostId_Post = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comenta", x => x.ID_Comenta);
                    table.ForeignKey(
                        name: "FK_Comenta_Post_PostId_Post",
                        column: x => x.PostId_Post,
                        principalTable: "Post",
                        principalColumn: "Id_Post");
                    table.ForeignKey(
                        name: "FK_Comenta_Utilizador_Autenticado_UtilizadorAutenticadoId_Util",
                        column: x => x.UtilizadorAutenticadoId_Util,
                        principalTable: "Utilizador_Autenticado",
                        principalColumn: "Id_Util");
                });

            migrationBuilder.CreateTable(
                name: "PartilhaGrupo",
                columns: table => new
                {
                    ID_PartilhaGrupo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Grupo = table.Column<int>(type: "int", nullable: false),
                    ID_Post = table.Column<int>(type: "int", nullable: false),
                    GrupoId_Grupo = table.Column<int>(type: "int", nullable: false),
                    PostId_Post = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartilhaGrupo", x => x.ID_PartilhaGrupo);
                    table.ForeignKey(
                        name: "FK_PartilhaGrupo_Grupo_GrupoId_Grupo",
                        column: x => x.GrupoId_Grupo,
                        principalTable: "Grupo",
                        principalColumn: "Id_Grupo");
                    table.ForeignKey(
                        name: "FK_PartilhaGrupo_Post_PostId_Post",
                        column: x => x.PostId_Post,
                        principalTable: "Post",
                        principalColumn: "Id_Post");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_postId_Post",
                table: "Anexo",
                column: "postId_Post");

            migrationBuilder.CreateIndex(
                name: "IX_Comenta_PostId_Post",
                table: "Comenta",
                column: "PostId_Post");

            migrationBuilder.CreateIndex(
                name: "IX_Comenta_UtilizadorAutenticadoId_Util",
                table: "Comenta",
                column: "UtilizadorAutenticadoId_Util");

            migrationBuilder.CreateIndex(
                name: "IX_Ficheiro_Utilizador_AutenticadoId_Util",
                table: "Ficheiro",
                column: "Utilizador_AutenticadoId_Util");

            migrationBuilder.CreateIndex(
                name: "IX_Grupo_UtilizadorId_Util",
                table: "Grupo",
                column: "UtilizadorId_Util");

            migrationBuilder.CreateIndex(
                name: "IX_Partilha_FicheiroId_Ficheiro",
                table: "Partilha",
                column: "FicheiroId_Ficheiro");

            migrationBuilder.CreateIndex(
                name: "IX_Partilha_GrupoId_Grupo",
                table: "Partilha",
                column: "GrupoId_Grupo");

            migrationBuilder.CreateIndex(
                name: "IX_PartilhaGrupo_GrupoId_Grupo",
                table: "PartilhaGrupo",
                column: "GrupoId_Grupo");

            migrationBuilder.CreateIndex(
                name: "IX_PartilhaGrupo_PostId_Post",
                table: "PartilhaGrupo",
                column: "PostId_Post");

            migrationBuilder.CreateIndex(
                name: "IX_PedeAcesso_GrupoId_Grupo",
                table: "PedeAcesso",
                column: "GrupoId_Grupo");

            migrationBuilder.CreateIndex(
                name: "IX_PedeAcesso_UtilizadorAutenticadoId_Util",
                table: "PedeAcesso",
                column: "UtilizadorAutenticadoId_Util");

            migrationBuilder.CreateIndex(
                name: "IX_Pertence_GrupoId_Grupo",
                table: "Pertence",
                column: "GrupoId_Grupo");

            migrationBuilder.CreateIndex(
                name: "IX_Pertence_UtilizadorAutenticadoId_Util",
                table: "Pertence",
                column: "UtilizadorAutenticadoId_Util");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Utilizador_AutenticadoId_Util",
                table: "Post",
                column: "Utilizador_AutenticadoId_Util");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropTable(
                name: "Anexo");

            migrationBuilder.DropTable(
                name: "Comenta");

            migrationBuilder.DropTable(
                name: "Partilha");

            migrationBuilder.DropTable(
                name: "PartilhaGrupo");

            migrationBuilder.DropTable(
                name: "PedeAcesso");

            migrationBuilder.DropTable(
                name: "Pertence");

            migrationBuilder.DropTable(
                name: "Ficheiro");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "Utilizador_Autenticado");
        }
    }
}
