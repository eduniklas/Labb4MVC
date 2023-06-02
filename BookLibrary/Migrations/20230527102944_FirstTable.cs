using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookLibrary.Migrations
{
    /// <inheritdoc />
    public partial class FirstTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Published = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_CustomerId = table.Column<int>(type: "int", nullable: false),
                    FK_BookId = table.Column<int>(type: "int", nullable: false),
                    LoanDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Returned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanListId);
                    table.ForeignKey(
                        name: "FK_Loans_Books_FK_BookId",
                        column: x => x.FK_BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Customers_FK_CustomerId",
                        column: x => x.FK_CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Description", "Published", "Title" },
                values: new object[,]
                {
                    { 1, "George Orwell", "This is a dystopian novel set in a totalitarian society ruled by a party that exercises absolute control over its citizens. The story follows Winston Smith, a low-ranking member of the ruling party, as he becomes disillusioned with the oppressive regime and begins to rebel", new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "1984" },
                    { 2, "J.R.R. Tolkien", "Tolkien’s fantasy epic is one of the top must-read books out there. Set in Middle Earth – a world full of hobbits, elves, orcs, goblins, and wizards – The Lord of the Rings will take you on an unbelievable adventure", new DateTime(1954, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings" },
                    { 3, "J.K. Rowling", "This global bestseller took the world by storm. So, if you haven’t read J.K. Rowling’s Harry Potter, now may be the time. Join Harry Potter and his schoolmates as this must-read book transports you deep into a world of magic and monsters", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter and the Philosopher’s Stone" },
                    { 4, "C.S. Lewis", "The Lion, The Witch, and the Wardrobe is undoubtedly one of the great books of all time. This renowned fantasy novel is set in Narnia, home to mythical beasts, talking animals, and warring kingdoms. The story follows a group of school children as they become entangled in this incredible world’s fate", new DateTime(1950, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lion, the Witch, and the Wardrobe" },
                    { 5, "George Orwell", "Orwell tells a fairy tale of a revolution against tyranny that ends in even more unjust totalitarianism. The animals on the farm are rife with idealism and desire to create a world of justice, equality, and progress. However, the new regimen attempts to control every aspect of the animals’ lives", new DateTime(1945, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animal Farm" },
                    { 6, "Douglas Adams", "Arthur Dent sets off on a hilarious and fantastic adventure across the stars. He learns not to take the universe seriously as he meets all kinds of interesting characters.", new DateTime(1979, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hitchhiker’s Guide to the Galaxy" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "LastName", "RegisteredDate" },
                values: new object[,]
                {
                    { 1, "Vincent", "Chase", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Eric", "Murphy", new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Johnny", "Drama", new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Turtle", "Assante", new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Ari", "Gold", new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_FK_BookId",
                table: "Loans",
                column: "FK_BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_FK_CustomerId",
                table: "Loans",
                column: "FK_CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
