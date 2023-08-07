using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class editStatusRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobStatusJobs");

            migrationBuilder.DropTable(
                name: "TbStatusJobBridge");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "TbJobs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TbJobs_StatusId",
                table: "TbJobs",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_TbJobStatus_StatusId",
                table: "TbJobs",
                column: "StatusId",
                principalTable: "TbJobStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_TbJobStatus_StatusId",
                table: "TbJobs");

            migrationBuilder.DropIndex(
                name: "IX_TbJobs_StatusId",
                table: "TbJobs");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "TbJobs");

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

            migrationBuilder.CreateIndex(
                name: "IX_JobStatusJobs_statusId",
                table: "JobStatusJobs",
                column: "statusId");
        }
    }
}
