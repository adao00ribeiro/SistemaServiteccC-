using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaServitec.Migrations
{
    /// <inheritdoc />
    public partial class Contract : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonLocadorId = table.Column<int>(type: "INTEGER", maxLength: 255, nullable: false),
                    PersonLocatarioId = table.Column<int>(type: "INTEGER", maxLength: 255, nullable: false),
                    TipoImovel = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Endereco = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Numero = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Bairro = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Cidade = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Estado = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    CEP = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    TipoDuracao = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Duracao = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    DuracaoExtenso = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    DataInicial = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    DataFinal = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Valor = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ValorExtenso = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    DataContrato = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Persons_PersonLocadorId",
                        column: x => x.PersonLocadorId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Persons_PersonLocatarioId",
                        column: x => x.PersonLocatarioId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_PersonLocadorId",
                table: "Contracts",
                column: "PersonLocadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_PersonLocatarioId",
                table: "Contracts",
                column: "PersonLocatarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");
        }
    }
}
