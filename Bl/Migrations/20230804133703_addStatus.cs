using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class addStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbJobStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentState = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbJobStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbStatusJobBridge",
                columns: table => new
                {
                    jobId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbStatusJobBridge", x => new { x.jobId, x.StatusId });
                });

            migrationBuilder.CreateTable(
                name: "JobStatusJobs",
                columns: table => new
                {
                    jobsId = table.Column<int>(type: "int", nullable: false),
                    statusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobStatusJobs", x => new { x.jobsId, x.statusId });
                    table.ForeignKey(
                        name: "FK_JobStatusJobs_TbJobStatus_statusId",
                        column: x => x.statusId,
                        principalTable: "TbJobStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobStatusJobs_TbJobs_jobsId",
                        column: x => x.jobsId,
                        principalTable: "TbJobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobStatusJobs_statusId",
                table: "JobStatusJobs",
                column: "statusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobStatusJobs");

            migrationBuilder.DropTable(
                name: "TbStatusJobBridge");

            migrationBuilder.DropTable(
                name: "TbJobStatus");
        }
    }
}
