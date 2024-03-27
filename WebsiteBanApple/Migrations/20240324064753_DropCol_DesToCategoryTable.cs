using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteBanApple.Migrations
{
    /// <inheritdoc />
    public partial class DropCol_DesToCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Description", table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Description", table: "Categories");
        }
    }
}
