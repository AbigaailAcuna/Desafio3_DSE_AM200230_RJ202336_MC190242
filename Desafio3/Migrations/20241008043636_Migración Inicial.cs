using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Desafio3.Migrations
{
    /// <inheritdoc />
    public partial class MigraciónInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreReceta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DescripcionReceta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiempoPreparacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreIngrediente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CantidadIngrediente = table.Column<int>(type: "int", nullable: false),
                    UnidadMedida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecetaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredientes_Recetas_RecetaID",
                        column: x => x.RecetaID,
                        principalTable: "Recetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Preparaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionPaso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdenPaso = table.Column<int>(type: "int", nullable: false),
                    RecetaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preparaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preparaciones_Recetas_RecetaID",
                        column: x => x.RecetaID,
                        principalTable: "Recetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Recetas",
                columns: new[] { "Id", "DescripcionReceta", "NombreReceta", "TiempoPreparacion" },
                values: new object[,]
                {
                    { 1, "Ensalada clásica con pollo, lechuga y aderezo césar.", "Ensalada César", "20 minutos" },
                    { 2, "Pasta con salsa de crema, huevo y queso parmesano.", "Pasta Carbonara", "30 minutos" },
                    { 3, "Sopa ligera de tomate con albahaca.", "Sopa de Tomate", "40 minutos" }
                });

            migrationBuilder.InsertData(
                table: "Ingredientes",
                columns: new[] { "Id", "CantidadIngrediente", "NombreIngrediente", "RecetaID", "UnidadMedida" },
                values: new object[,]
                {
                    { 1, 1, "Lechuga Romana", 1, "Unidad" },
                    { 2, 200, "Pollo a la parrilla", 1, "Gramos" },
                    { 3, 50, "Aderezo césar", 1, "Mililitros" },
                    { 4, 250, "Pasta espagueti", 2, "Gramos" },
                    { 5, 100, "Crema de leche", 2, "Mililitros" },
                    { 6, 1, "Huevo", 2, "Unidad" },
                    { 7, 50, "Queso Parmesano", 2, "Gramos" },
                    { 8, 500, "Tomates Frescos", 3, "Gramos" },
                    { 9, 5, "Albahaca", 3, "Hojas" }
                });

            migrationBuilder.InsertData(
                table: "Preparaciones",
                columns: new[] { "Id", "DescripcionPaso", "OrdenPaso", "RecetaID" },
                values: new object[,]
                {
                    { 1, "Lavar la lechuga romana y cortarla en trozos", 1, 1 },
                    { 2, "Asar el pollo a la parrilla y cortarlo en tiras.", 2, 1 },
                    { 3, "Mezclar la lechuga, el pollo y el aderezo césar.", 3, 1 },
                    { 4, "Cocinar la pasta en agua hirviendo con sal.", 1, 2 },
                    { 5, "Mezclar el huevo, a crema y el queso parmesano.", 2, 2 },
                    { 6, "Añadir la mezcla a la pasta caliente.", 3, 2 },
                    { 7, "Cortar los tomates y hervirlos hasta que se ablanden.", 1, 3 },
                    { 8, "Licuar los tomates y agregar la albahaca.", 2, 3 },
                    { 9, "Cocinar por 10 minutos más y servir caliente.", 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_RecetaID",
                table: "Ingredientes",
                column: "RecetaID");

            migrationBuilder.CreateIndex(
                name: "IX_Preparaciones_RecetaID",
                table: "Preparaciones",
                column: "RecetaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "Preparaciones");

            migrationBuilder.DropTable(
                name: "Recetas");
        }
    }
}
