using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class confirmCandidaties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbCategoryCandidates");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "TbCandidates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "gradutionYear",
                table: "TbCandidates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "skils",
                table: "TbCandidates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "universty",
                table: "TbCandidates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbCandidates_CategoriesId",
                table: "TbCandidates",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbCandidates_TbCategory_CategoriesId",
                table: "TbCandidates",
                column: "CategoriesId",
                principalTable: "TbCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbCandidates_TbCategory_CategoriesId",
                table: "TbCandidates");

            migrationBuilder.DropIndex(
                name: "IX_TbCandidates_CategoriesId",
                table: "TbCandidates");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "TbCandidates");

            migrationBuilder.DropColumn(
                name: "gradutionYear",
                table: "TbCandidates");

            migrationBuilder.DropColumn(
                name: "skils",
                table: "TbCandidates");

            migrationBuilder.DropColumn(
                name: "universty",
                table: "TbCandidates");

            migrationBuilder.CreateTable(
                name: "TbCategoryCandidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    candidateId = table.Column<int>(type: "int", nullable: true),
                    categoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentState = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCategoryCandidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbCategoryCandidates_TbCandidates_candidateId",
                        column: x => x.candidateId,
                        principalTable: "TbCandidates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TbCategoryCandidates_TbCategory_categoryId",
                        column: x => x.categoryId,
                        principalTable: "TbCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbCategoryCandidates_candidateId",
                table: "TbCategoryCandidates",
                column: "candidateId");

            migrationBuilder.CreateIndex(
                name: "IX_TbCategoryCandidates_categoryId",
                table: "TbCategoryCandidates",
                column: "categoryId");
        }
    }
}
