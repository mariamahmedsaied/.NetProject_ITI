using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolLibraryStore.Migrations
{
    /// <inheritdoc />
    public partial class DesignCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Our STEM book selection features captivating stories and hands-on activities that encourage creativity and critical thinking in Science, Technology, Engineering, and Mathematics.", "STEM" },
                    { 2, "Our Humanities collection offers a rich array of books that delve into history, literature, art, and culture, encouraging critical thinking and empathy.", "Humanities" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "Ramy.Ahmed@School.com", "Ramy", "Ahmed", "12345" },
                    { 2, "Ali.Saied@School.com", "Ali", "Saied", "22345" },
                    { 3, "Mohammed.Moussa@School.com", "Mohamed", "Moussa", "32345" },
                    { 4, "Ahmed.Sayed@School.com", "Ahmed", "Sayed", "42345" },
                    { 5, "Hala.Mohmoudd@School.com", "Hala", "Mahmoud", "52345" },
                    { 6, "Mai.Sami@School.com", "Mai", "Sami", "62345" },
                    { 7, "Omar.Sabry@School.com", "Omar", "Sabry", "72345" },
                    { 8, "Sara.Ali@School.com", "Sara", "Ali", "82345" },
                    { 9, "Mostafa.Nabil@School.com", "Mostafa", "Nabil", "92345" },
                    { 10, "Nour.Gerges@School.com", "Nour", "Gerges", "02345" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImagePath", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, 1, "A comprehensive guide to basic algebra concepts for middle school students.", "/images/books/algebra_intro.jpg", 1630m, 15, "Introduction to Algebra" },
                    { 2, 2, "A detailed account of ancient civilizations and their impact on modern society.", "/images/books/history_vol1.jpg", 250m, 8, "World History Volume I" },
                    { 3, 2, "A collection of Shakespeare’s sonnets, exploring themes of love, time, and beauty.", "/images/books/shakespeare_sonnets.jpg", 780m, 20, "Shakespeare's Sonnets" },
                    { 4, 1, "Hands-on chemistry experiments designed for high school students.", "/images/books/chemistry_experiments.jpg", 2800m, 12, "Chemistry Experiments" },
                    { 5, 2, "F. Scott Fitzgerald's classic novel set in the Roaring Twenties.", "/images/books/great_gatsby.jpg", 450m, 7, "The Great Gatsby" },
                    { 6, 1, "A foundational textbook covering basic physics laws and principles.", "/images/books/physics_principles.jpg", 1500m, 5, "Physics Principles" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
