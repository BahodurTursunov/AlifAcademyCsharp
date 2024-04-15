using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_ERM.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessProcess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Domain = table.Column<string>(type: "NVARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessProcess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiskProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(500)", nullable: false),
                    OccurrenceProbability = table.Column<int>(type: "INTEGER)", nullable: false),
                    PotentialBusinessImpact = table.Column<int>(type: "INTEGER)", nullable: false),
                    PotentialSolution = table.Column<string>(type: "NVARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskProfile_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RiskProfile_BusinessProcessId",
                table: "RiskProfile",
                column: "BusinessProcessId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiskProfile");

            migrationBuilder.DropTable(
                name: "BusinessProcess");
        }
    }
}
