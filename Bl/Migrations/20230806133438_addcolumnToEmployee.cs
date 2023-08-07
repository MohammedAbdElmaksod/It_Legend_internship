using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class addcolumnToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "companyCategoriesId",
                table: "TbEmplyees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompanyCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentState = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCategories", x => x.Id);
                    
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbEmplyees_companyCategoriesId",
                table: "TbEmplyees",
                column: "companyCategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmplyees_CompanyCategories_companyCategoriesId",
                table: "TbEmplyees",
                column: "companyCategoriesId",
                principalTable: "CompanyCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbEmplyees_CompanyCategories_companyCategoriesId",
                table: "TbEmplyees");

            migrationBuilder.DropTable(
                name: "CompanyCategories");

            migrationBuilder.DropIndex(
                name: "IX_TbEmplyees_companyCategoriesId",
                table: "TbEmplyees");

            migrationBuilder.DropColumn(
                name: "companyCategoriesId",
                table: "TbEmplyees");
        }
    }
}
