using Microsoft.EntityFrameworkCore.Migrations;

namespace CaseStudy.Migrations
{
    public partial class azure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLineItems_Products_ProductId",
                table: "OrderLineItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderLineItems_ProductId",
                table: "OrderLineItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItems_ProductId",
                table: "OrderLineItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLineItems_Products_ProductId",
                table: "OrderLineItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
