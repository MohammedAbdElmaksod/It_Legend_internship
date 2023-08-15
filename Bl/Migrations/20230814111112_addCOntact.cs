using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class addCOntact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbContact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Government = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CandidateId = table.Column<int>(type: "int", nullable: true),
                    CurrentState = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbContact_TbCandidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "TbCandidates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TbContact_TbEmplyees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "TbEmplyees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbContact_CandidateId",
                table: "TbContact",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_TbContact_EmployeeId",
                table: "TbContact",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbContact");
        }
    }
}
