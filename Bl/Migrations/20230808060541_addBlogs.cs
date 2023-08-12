using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class addBlogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbBlogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CommentCount = table.Column<int>(type: "int", nullable: true),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    CandidateId = table.Column<int>(type: "int", nullable: true),
                    CurrentState = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbBlogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbBlogs_TbCandidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "TbCandidates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TbBlogs_TbEmplyees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "TbEmplyees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbBlogs_CandidateId",
                table: "TbBlogs",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_TbBlogs_employeeId",
                table: "TbBlogs",
                column: "employeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbBlogs");
        }
    }
}
