using System;
using System.Data;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class addJobTypePrivaceyStaatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrivaceyId",
                table: "TbJobs",
                type: "int",
                nullable: true,
                defaultValue: 0);
            

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "TbJobs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TbJobPrivacey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    privacey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentState = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbJobPrivacey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbJobStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbJobStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbJobType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentState = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbJobType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbJobStatusBridge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statusId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    jobsId = table.Column<int>(type: "int", nullable: true),
                    CurrentState = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbJobStatusBridge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbJobStatusBridge_TbJobStatus_statusId",
                        column: x => x.statusId,
                        principalTable: "TbJobStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbJobStatusBridge_TbJobs_jobsId",
                        column: x => x.jobsId,
                        principalTable: "TbJobs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbJobs_PrivaceyId",
                table: "TbJobs",
                column: "PrivaceyId");

            migrationBuilder.CreateIndex(
                name: "IX_TbJobs_TypeId",
                table: "TbJobs",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TbJobStatusBridge_jobsId",
                table: "TbJobStatusBridge",
                column: "jobsId");

            migrationBuilder.CreateIndex(
                name: "IX_TbJobStatusBridge_statusId",
                table: "TbJobStatusBridge",
                column: "statusId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_TbJobPrivacey_PrivaceyId",
                table: "TbJobs",
                column: "PrivaceyId",
                principalTable: "TbJobPrivacey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_TbJobType_TypeId",
                table: "TbJobs",
                column: "TypeId",
                principalTable: "TbJobType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_TbJobPrivacey_PrivaceyId",
                table: "TbJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_TbJobType_TypeId",
                table: "TbJobs");

            migrationBuilder.DropTable(
                name: "TbJobPrivacey");

            migrationBuilder.DropTable(
                name: "TbJobStatusBridge");

            migrationBuilder.DropTable(
                name: "TbJobType");

            migrationBuilder.DropTable(
                name: "TbJobStatus");

            migrationBuilder.DropIndex(
                name: "IX_TbJobs_PrivaceyId",
                table: "TbJobs");

            migrationBuilder.DropIndex(
                name: "IX_TbJobs_TypeId",
                table: "TbJobs");

            migrationBuilder.DropColumn(
                name: "PrivaceyId",
                table: "TbJobs");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "TbJobs");
        }
    }
}
