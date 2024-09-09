using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Infrastructure.Migrations
{
    public partial class LinkSetEfficiency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 1,
                columns: new[] { "Abs", "Arms", "Back", "BasicalSetId", "Cardio", "Chest", "Legs" },
                values: new object[] { 2, 3, 1, 1, 0, 5, 4 });

            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 2,
                columns: new[] { "Abs", "Arms", "Back", "BasicalSetId", "Cardio", "Chest", "Legs" },
                values: new object[] { 2, 3, 1, 2, 1, 4, 0 });

            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 3,
                columns: new[] { "Abs", "Arms", "Back", "BasicalSetId", "Cardio", "Chest", "Legs" },
                values: new object[] { 3, 2, 1, 3, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 4,
                columns: new[] { "Abs", "Back", "BasicalSetId" },
                values: new object[] { 2, 1, 4 });

            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 5,
                columns: new[] { "Abs", "Back", "BasicalSetId", "Cardio", "Chest", "Legs" },
                values: new object[] { 3, 1, 5, 1, 0, 3 });

            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 6,
                columns: new[] { "Abs", "Back", "BasicalSetId", "Cardio", "Chest" },
                values: new object[] { 2, 1, 6, 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 1,
                columns: new[] { "Abs", "Arms", "Back", "BasicalSetId", "Cardio", "Chest", "Legs" },
                values: new object[] { 4, 2, 3, 0, 5, 2, 3 });

            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 2,
                columns: new[] { "Abs", "Arms", "Back", "BasicalSetId", "Cardio", "Chest", "Legs" },
                values: new object[] { 3, 1, 4, 0, 4, 0, 5 });

            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 3,
                columns: new[] { "Abs", "Arms", "Back", "BasicalSetId", "Cardio", "Chest", "Legs" },
                values: new object[] { 2, 5, 4, 0, 2, 5, 1 });

            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 4,
                columns: new[] { "Abs", "Back", "BasicalSetId" },
                values: new object[] { 5, 3, 0 });

            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 5,
                columns: new[] { "Abs", "Back", "BasicalSetId", "Cardio", "Chest", "Legs" },
                values: new object[] { 2, 5, 0, 3, 4, 4 });

            migrationBuilder.UpdateData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 6,
                columns: new[] { "Abs", "Back", "BasicalSetId", "Cardio", "Chest" },
                values: new object[] { 4, 0, 0, 5, 2 });

            migrationBuilder.InsertData(
                table: "BasicalSetEfficiency",
                columns: new[] { "EfficiencyId", "Abs", "Arms", "Back", "BasicalSetId", "Cardio", "Chest", "Legs" },
                values: new object[] { 7, 3, 4, 4, 0, 2, 3, 4 });
        }
    }
}
