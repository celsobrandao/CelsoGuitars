using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CelsoGuitars.Repository.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TiposServicos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    MinutosExecucao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposServicos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Captadores",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoCaptador = table.Column<byte>(type: "tinyint", nullable: false),
                    TipoCaptadorOutro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Resistencia = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    CorCaptador = table.Column<byte>(type: "tinyint", nullable: false),
                    CorCaptadorOutro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MarcaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CodigoFabricante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Captadores", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Captadores_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chaveamentos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoChaveamento = table.Column<byte>(type: "tinyint", nullable: false),
                    TipoChaveamentoOutro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MarcaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CodigoFabricante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chaveamentos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chaveamentos_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Madeiras",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarcaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CodigoFabricante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Madeiras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Madeiras_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pontes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarcaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CodigoFabricante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cor = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pontes_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarraxas",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndicaComTrava = table.Column<bool>(type: "bit", nullable: false),
                    MarcaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CodigoFabricante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cor = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarraxas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tarraxas_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trastes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarcaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CodigoFabricante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cor = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trastes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Trastes_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bracos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MadeiraBracoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MadeiraEscalaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComprimentoEscala = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    QuantidadeTrastes = table.Column<byte>(type: "tinyint", nullable: false),
                    Formato = table.Column<byte>(type: "tinyint", nullable: false),
                    FormatoOutro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RaioEscala = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    JuncaoBraco = table.Column<byte>(type: "tinyint", nullable: false),
                    JuncaoBracoOutro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MarcaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CodigoFabricante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bracos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bracos_Madeiras_MadeiraBracoID",
                        column: x => x.MadeiraBracoID,
                        principalTable: "Madeiras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bracos_Madeiras_MadeiraEscalaID",
                        column: x => x.MadeiraEscalaID,
                        principalTable: "Madeiras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bracos_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Corpos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MadeiraCorpoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MadeiraTopoID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Cor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MarcaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CodigoFabricante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corpos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Corpos_Madeiras_MadeiraCorpoID",
                        column: x => x.MadeiraCorpoID,
                        principalTable: "Madeiras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Corpos_Madeiras_MadeiraTopoID",
                        column: x => x.MadeiraTopoID,
                        principalTable: "Madeiras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Corpos_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Guitarras",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BracoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CorpoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfiguracaoCaptadores = table.Column<byte>(type: "tinyint", nullable: false),
                    ConfiguracaoCaptadoresOutro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PonteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TarraxaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrasteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MarcaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CodigoFabricante = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guitarras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Guitarras_Bracos_BracoID",
                        column: x => x.BracoID,
                        principalTable: "Bracos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guitarras_Corpos_CorpoID",
                        column: x => x.CorpoID,
                        principalTable: "Corpos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guitarras_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guitarras_Pontes_PonteID",
                        column: x => x.PonteID,
                        principalTable: "Pontes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guitarras_Tarraxas_TarraxaID",
                        column: x => x.TarraxaID,
                        principalTable: "Tarraxas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guitarras_Trastes_TrasteID",
                        column: x => x.TrasteID,
                        principalTable: "Trastes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CaptadorGuitarra",
                columns: table => new
                {
                    CaptadoresID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuitarrasID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaptadorGuitarra", x => new { x.CaptadoresID, x.GuitarrasID });
                    table.ForeignKey(
                        name: "FK_CaptadorGuitarra_Captadores_CaptadoresID",
                        column: x => x.CaptadoresID,
                        principalTable: "Captadores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaptadorGuitarra_Guitarras_GuitarrasID",
                        column: x => x.GuitarrasID,
                        principalTable: "Guitarras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChaveamentoGuitarra",
                columns: table => new
                {
                    ChaveamentosID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuitarrasID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChaveamentoGuitarra", x => new { x.ChaveamentosID, x.GuitarrasID });
                    table.ForeignKey(
                        name: "FK_ChaveamentoGuitarra_Chaveamentos_ChaveamentosID",
                        column: x => x.ChaveamentosID,
                        principalTable: "Chaveamentos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChaveamentoGuitarra_Guitarras_GuitarrasID",
                        column: x => x.GuitarrasID,
                        principalTable: "Guitarras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdensServicos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GuitarraID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataInicioServico = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataSaidaPrevista = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataSaidaEfetiva = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValorPrevisto = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false),
                    PercentualDesconto = table.Column<decimal>(type: "decimal(5,4)", precision: 5, scale: 4, nullable: false),
                    ValorEfetivo = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdensServicos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrdensServicos_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrdensServicos_Guitarras_GuitarraID",
                        column: x => x.GuitarraID,
                        principalTable: "Guitarras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdemServicoTipoServico",
                columns: table => new
                {
                    OrdensServicosID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TiposServicosID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServicoTipoServico", x => new { x.OrdensServicosID, x.TiposServicosID });
                    table.ForeignKey(
                        name: "FK_OrdemServicoTipoServico_OrdensServicos_OrdensServicosID",
                        column: x => x.OrdensServicosID,
                        principalTable: "OrdensServicos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdemServicoTipoServico_TiposServicos_TiposServicosID",
                        column: x => x.TiposServicosID,
                        principalTable: "TiposServicos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bracos_MadeiraBracoID",
                table: "Bracos",
                column: "MadeiraBracoID");

            migrationBuilder.CreateIndex(
                name: "IX_Bracos_MadeiraEscalaID",
                table: "Bracos",
                column: "MadeiraEscalaID");

            migrationBuilder.CreateIndex(
                name: "IX_Bracos_MarcaID",
                table: "Bracos",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Captadores_MarcaID",
                table: "Captadores",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_CaptadorGuitarra_GuitarrasID",
                table: "CaptadorGuitarra",
                column: "GuitarrasID");

            migrationBuilder.CreateIndex(
                name: "IX_ChaveamentoGuitarra_GuitarrasID",
                table: "ChaveamentoGuitarra",
                column: "GuitarrasID");

            migrationBuilder.CreateIndex(
                name: "IX_Chaveamentos_MarcaID",
                table: "Chaveamentos",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Corpos_MadeiraCorpoID",
                table: "Corpos",
                column: "MadeiraCorpoID");

            migrationBuilder.CreateIndex(
                name: "IX_Corpos_MadeiraTopoID",
                table: "Corpos",
                column: "MadeiraTopoID");

            migrationBuilder.CreateIndex(
                name: "IX_Corpos_MarcaID",
                table: "Corpos",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Guitarras_BracoID",
                table: "Guitarras",
                column: "BracoID");

            migrationBuilder.CreateIndex(
                name: "IX_Guitarras_CorpoID",
                table: "Guitarras",
                column: "CorpoID");

            migrationBuilder.CreateIndex(
                name: "IX_Guitarras_MarcaID",
                table: "Guitarras",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Guitarras_PonteID",
                table: "Guitarras",
                column: "PonteID");

            migrationBuilder.CreateIndex(
                name: "IX_Guitarras_TarraxaID",
                table: "Guitarras",
                column: "TarraxaID");

            migrationBuilder.CreateIndex(
                name: "IX_Guitarras_TrasteID",
                table: "Guitarras",
                column: "TrasteID");

            migrationBuilder.CreateIndex(
                name: "IX_Madeiras_MarcaID",
                table: "Madeiras",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServicoTipoServico_TiposServicosID",
                table: "OrdemServicoTipoServico",
                column: "TiposServicosID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdensServicos_ClienteID",
                table: "OrdensServicos",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdensServicos_GuitarraID",
                table: "OrdensServicos",
                column: "GuitarraID");

            migrationBuilder.CreateIndex(
                name: "IX_Pontes_MarcaID",
                table: "Pontes",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Tarraxas_MarcaID",
                table: "Tarraxas",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Trastes_MarcaID",
                table: "Trastes",
                column: "MarcaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaptadorGuitarra");

            migrationBuilder.DropTable(
                name: "ChaveamentoGuitarra");

            migrationBuilder.DropTable(
                name: "OrdemServicoTipoServico");

            migrationBuilder.DropTable(
                name: "Captadores");

            migrationBuilder.DropTable(
                name: "Chaveamentos");

            migrationBuilder.DropTable(
                name: "OrdensServicos");

            migrationBuilder.DropTable(
                name: "TiposServicos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Guitarras");

            migrationBuilder.DropTable(
                name: "Bracos");

            migrationBuilder.DropTable(
                name: "Corpos");

            migrationBuilder.DropTable(
                name: "Pontes");

            migrationBuilder.DropTable(
                name: "Tarraxas");

            migrationBuilder.DropTable(
                name: "Trastes");

            migrationBuilder.DropTable(
                name: "Madeiras");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
