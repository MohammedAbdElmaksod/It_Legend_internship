using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class addJobKind : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KindId",
                table: "TbJobs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "JobKind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentState = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobKind", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbJobs_KindId",
                table: "TbJobs",
                column: "KindId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_JobKind_KindId",
                table: "TbJobs",
                column: "KindId",
                principalTable: "JobKind",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_JobKind_KindId",
                table: "TbJobs");

            migrationBuilder.DropTable(
                name: "JobKind");

            migrationBuilder.DropIndex(
                name: "IX_TbJobs_KindId",
                table: "TbJobs");

            migrationBuilder.DropColumn(
                name: "KindId",
                table: "TbJobs");
        }
    }
}
