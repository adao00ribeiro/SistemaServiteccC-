using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaServitec.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    DataNascimento = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    PaisNacionalidade = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Municipio = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Pais = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Residencia = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Numero = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    complemento = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Bairro = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Municipio = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    UF = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Pais = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    CEP = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    PersonId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresss_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Identitys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CPF = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    RG = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    OrgaoExpedicao = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    UF = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Data = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PersonId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identitys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identitys_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresss_PersonId",
                table: "Addresss",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Identitys_PersonId",
                table: "Identitys",
                column: "PersonId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresss");

            migrationBuilder.DropTable(
                name: "Identitys");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
