using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction");

            migrationBuilder.DropTable(
                name: "ProductTransaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductTransaction",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    TransactionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTransaction", x => new { x.ProductsId, x.TransactionsId });
                    table.ForeignKey(
                        name: "FK_ProductTransaction_Product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTransaction_Transaction_TransactionsId",
                        column: x => x.TransactionsId,
                        principalTable: "Transaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTransaction_TransactionsId",
                table: "ProductTransaction",
                column: "TransactionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
