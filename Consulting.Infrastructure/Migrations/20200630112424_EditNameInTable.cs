using Microsoft.EntityFrameworkCore.Migrations;

namespace Consulting.Infrastructure.Migrations
{
    public partial class EditNameInTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaximumRates",
                table: "Missions");

            migrationBuilder.AddColumn<int>(
                name: "MaximumRate",
                table: "Missions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "Id", "Experience", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 1, "Junior", "Jawad", "Chemlal" },
                    { 2, "Medior", "Xavier", "Piekara" },
                    { 3, "Senior", "Loic", "Ramelot" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "ExperienceRequired", "MaximumRate", "Name" },
                values: new object[,]
                {
                    { 1, "Medior", 500, "Google" },
                    { 2, "Senior", 700, "Amazon" },
                    { 3, "Junior", 400, "NRB" }
                });

            migrationBuilder.InsertData(
                table: "ConsultantMissions",
                columns: new[] { "ConsultantId", "MissionId", "isActive" },
                values: new object[,]
                {
                    { 2, 1, true },
                    { 3, 1, false },
                    { 3, 2, true },
                    { 1, 3, true },
                    { 2, 3, false },
                    { 3, 3, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConsultantMissions",
                keyColumns: new[] { "ConsultantId", "MissionId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ConsultantMissions",
                keyColumns: new[] { "ConsultantId", "MissionId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ConsultantMissions",
                keyColumns: new[] { "ConsultantId", "MissionId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ConsultantMissions",
                keyColumns: new[] { "ConsultantId", "MissionId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ConsultantMissions",
                keyColumns: new[] { "ConsultantId", "MissionId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ConsultantMissions",
                keyColumns: new[] { "ConsultantId", "MissionId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Consultants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Consultants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Consultants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "MaximumRate",
                table: "Missions");

            migrationBuilder.AddColumn<int>(
                name: "MaximumRates",
                table: "Missions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
