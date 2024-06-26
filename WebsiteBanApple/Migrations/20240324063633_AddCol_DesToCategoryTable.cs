﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteBanApple.Migrations
{
    /// <inheritdoc />
    public partial class AddCol_DesToCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(name: "Description", table: "Categories", type: "nvarchar(max)", nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Description", table: "Categories");
        }
    }
}
