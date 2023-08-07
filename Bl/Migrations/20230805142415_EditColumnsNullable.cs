using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class EditColumnsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbCandidates_TbSocila_socialMediaId",
                table: "TbCandidates");

            migrationBuilder.DropForeignKey(
                name: "FK_TbCategoryCandidates_TbCandidates_candidateId",
                table: "TbCategoryCandidates");

            migrationBuilder.DropForeignKey(
                name: "FK_TbCategoryCandidates_TbCategory_categoryId",
                table: "TbCategoryCandidates");

            migrationBuilder.DropForeignKey(
                name: "FK_TbEmplyees_TbSocila_socialMediaId",
                table: "TbEmplyees");

            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_JobKind_KindId",
                table: "TbJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_TbCategory_CategoryId",
                table: "TbJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_TbJobPrivacey_PrivaceyId",
                table: "TbJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_TbJobStatus_StatusId",
                table: "TbJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_TbJobType_TypeId",
                table: "TbJobs");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "TbJobs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "TbJobs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PrivaceyId",
                table: "TbJobs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KindId",
                table: "TbJobs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "TbJobs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "socialMediaId",
                table: "TbEmplyees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "TbEmplyees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "TbCategoryCandidates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "candidateId",
                table: "TbCategoryCandidates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "socialMediaId",
                table: "TbCandidates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "TbCandidates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TbCandidates_TbSocila_socialMediaId",
                table: "TbCandidates",
                column: "socialMediaId",
                principalTable: "TbSocila",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbCategoryCandidates_TbCandidates_candidateId",
                table: "TbCategoryCandidates",
                column: "candidateId",
                principalTable: "TbCandidates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbCategoryCandidates_TbCategory_categoryId",
                table: "TbCategoryCandidates",
                column: "categoryId",
                principalTable: "TbCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmplyees_TbSocila_socialMediaId",
                table: "TbEmplyees",
                column: "socialMediaId",
                principalTable: "TbSocila",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_JobKind_KindId",
                table: "TbJobs",
                column: "KindId",
                principalTable: "JobKind",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_TbCategory_CategoryId",
                table: "TbJobs",
                column: "CategoryId",
                principalTable: "TbCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_TbJobPrivacey_PrivaceyId",
                table: "TbJobs",
                column: "PrivaceyId",
                principalTable: "TbJobPrivacey",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_TbJobStatus_StatusId",
                table: "TbJobs",
                column: "StatusId",
                principalTable: "TbJobStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_TbJobType_TypeId",
                table: "TbJobs",
                column: "TypeId",
                principalTable: "TbJobType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbCandidates_TbSocila_socialMediaId",
                table: "TbCandidates");

            migrationBuilder.DropForeignKey(
                name: "FK_TbCategoryCandidates_TbCandidates_candidateId",
                table: "TbCategoryCandidates");

            migrationBuilder.DropForeignKey(
                name: "FK_TbCategoryCandidates_TbCategory_categoryId",
                table: "TbCategoryCandidates");

            migrationBuilder.DropForeignKey(
                name: "FK_TbEmplyees_TbSocila_socialMediaId",
                table: "TbEmplyees");

            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_JobKind_KindId",
                table: "TbJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_TbCategory_CategoryId",
                table: "TbJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_TbJobPrivacey_PrivaceyId",
                table: "TbJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_TbJobStatus_StatusId",
                table: "TbJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_TbJobs_TbJobType_TypeId",
                table: "TbJobs");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "TbJobs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "TbJobs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PrivaceyId",
                table: "TbJobs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KindId",
                table: "TbJobs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "TbJobs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "socialMediaId",
                table: "TbEmplyees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "TbEmplyees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "TbCategoryCandidates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "candidateId",
                table: "TbCategoryCandidates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "socialMediaId",
                table: "TbCandidates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "TbCandidates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TbCandidates_TbSocila_socialMediaId",
                table: "TbCandidates",
                column: "socialMediaId",
                principalTable: "TbSocila",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbCategoryCandidates_TbCandidates_candidateId",
                table: "TbCategoryCandidates",
                column: "candidateId",
                principalTable: "TbCandidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbCategoryCandidates_TbCategory_categoryId",
                table: "TbCategoryCandidates",
                column: "categoryId",
                principalTable: "TbCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbEmplyees_TbSocila_socialMediaId",
                table: "TbEmplyees",
                column: "socialMediaId",
                principalTable: "TbSocila",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_JobKind_KindId",
                table: "TbJobs",
                column: "KindId",
                principalTable: "JobKind",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_TbCategory_CategoryId",
                table: "TbJobs",
                column: "CategoryId",
                principalTable: "TbCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_TbJobPrivacey_PrivaceyId",
                table: "TbJobs",
                column: "PrivaceyId",
                principalTable: "TbJobPrivacey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_TbJobStatus_StatusId",
                table: "TbJobs",
                column: "StatusId",
                principalTable: "TbJobStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TbJobs_TbJobType_TypeId",
                table: "TbJobs",
                column: "TypeId",
                principalTable: "TbJobType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
