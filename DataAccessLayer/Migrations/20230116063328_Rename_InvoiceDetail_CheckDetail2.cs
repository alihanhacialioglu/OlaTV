using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class RenameInvoiceDetailCheckDetail2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_CreditCards_CreditCardId",
                table: "InvoiceDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceDetails",
                table: "InvoiceDetails");

            migrationBuilder.RenameTable(
                name: "InvoiceDetails",
                newName: "CheckDetails");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_CreditCardId",
                table: "CheckDetails",
                newName: "IX_CheckDetails_CreditCardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckDetails",
                table: "CheckDetails",
                column: "CheckDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckDetails_CreditCards_CreditCardId",
                table: "CheckDetails",
                column: "CreditCardId",
                principalTable: "CreditCards",
                principalColumn: "CreditCardId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckDetails_CreditCards_CreditCardId",
                table: "CheckDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckDetails",
                table: "CheckDetails");

            migrationBuilder.RenameTable(
                name: "CheckDetails",
                newName: "InvoiceDetails");

            migrationBuilder.RenameIndex(
                name: "IX_CheckDetails_CreditCardId",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_CreditCardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceDetails",
                table: "InvoiceDetails",
                column: "CheckDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_CreditCards_CreditCardId",
                table: "InvoiceDetails",
                column: "CreditCardId",
                principalTable: "CreditCards",
                principalColumn: "CreditCardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
