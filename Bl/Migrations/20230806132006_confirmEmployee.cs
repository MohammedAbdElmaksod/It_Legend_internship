using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class confirmEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            

            migrationBuilder.AddColumn<int>(
                name: "JobsId",
                table: "TbEmplyees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jobId",
                table: "TbEmplyees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbEmplyees_JobsId",
                table: "TbEmplyees",
                column: "JobsId");

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmplyees_TbJobs_JobsId",
                table: "TbEmplyees",
                column: "JobsId",
                principalTable: "TbJobs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbEmplyees_TbJobs_JobsId",
                table: "TbEmplyees");

            migrationBuilder.DropIndex(
                name: "IX_TbEmplyees_JobsId",
                table: "TbEmplyees");

            migrationBuilder.DropColumn(
                name: "JobsId",
                table: "TbEmplyees");

            migrationBuilder.DropColumn(
                name: "jobId",
                table: "TbEmplyees");

            
        }
    }
}
