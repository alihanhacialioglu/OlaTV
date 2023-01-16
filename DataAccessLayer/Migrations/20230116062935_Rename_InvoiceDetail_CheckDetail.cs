using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class RenameInvoiceDetailCheckDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InvoiceExplanation",
                table: "InvoiceDetails",
                newName: "CheckExplanation");

            migrationBuilder.RenameColumn(
                name: "InvoiceDate",
                table: "InvoiceDetails",
                newName: "CheckDate");

            migrationBuilder.RenameColumn(
                name: "InvoiceDetailId",
                table: "InvoiceDetails",
                newName: "CheckDetailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CheckExplanation",
                table: "InvoiceDetails",
                newName: "InvoiceExplanation");

            migrationBuilder.RenameColumn(
                name: "CheckDate",
                table: "InvoiceDetails",
                newName: "InvoiceDate");

            migrationBuilder.RenameColumn(
                name: "CheckDetailId",
                table: "InvoiceDetails",
                newName: "InvoiceDetailId");
        }
    }
}
