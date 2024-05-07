using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PADatabase.Migrations
{
    /// <inheritdoc />
    public partial class courseupdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InputModelId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Courses",
                newName: "Fee");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fee",
                table: "Courses",
                newName: "price");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InputModelId",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
