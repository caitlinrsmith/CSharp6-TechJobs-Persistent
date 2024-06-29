using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechJobs6Persistent.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSkills_Jobs_JobsId",
                table: "JobSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkills_Skills_SkillsId",
                table: "JobSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSkills",
                table: "JobSkills");

            migrationBuilder.RenameTable(
                name: "JobSkills",
                newName: "jobskill");

            migrationBuilder.RenameIndex(
                name: "IX_JobSkills_SkillsId",
                table: "jobskill",
                newName: "IX_jobskill_SkillsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jobskill",
                table: "jobskill",
                columns: new[] { "JobsId", "SkillsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_jobskill_Jobs_JobsId",
                table: "jobskill",
                column: "JobsId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_jobskill_Skills_SkillsId",
                table: "jobskill",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_jobskill_Jobs_JobsId",
                table: "jobskill");

            migrationBuilder.DropForeignKey(
                name: "FK_jobskill_Skills_SkillsId",
                table: "jobskill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jobskill",
                table: "jobskill");

            migrationBuilder.RenameTable(
                name: "jobskill",
                newName: "JobSkills");

            migrationBuilder.RenameIndex(
                name: "IX_jobskill_SkillsId",
                table: "JobSkills",
                newName: "IX_JobSkills_SkillsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSkills",
                table: "JobSkills",
                columns: new[] { "JobsId", "SkillsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkills_Jobs_JobsId",
                table: "JobSkills",
                column: "JobsId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkills_Skills_SkillsId",
                table: "JobSkills",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
