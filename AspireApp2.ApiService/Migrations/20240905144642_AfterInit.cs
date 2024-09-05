using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspireApp2.ApiService.Migrations
{
    /// <inheritdoc />
    public partial class AfterInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AfterInitBool",
                table: "SampleData",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AfterInitBoolWithAttributes",
                table: "SampleData",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AfterInitBoolWithDefaultValueAttribute",
                table: "SampleData",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AfterInitBool",
                table: "SampleData");

            migrationBuilder.DropColumn(
                name: "AfterInitBoolWithAttributes",
                table: "SampleData");

            migrationBuilder.DropColumn(
                name: "AfterInitBoolWithDefaultValueAttribute",
                table: "SampleData");
        }
    }
}
