using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crr.Data.Migrations
{
    public partial class ModifyTermPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Terms",
                table: "Terms");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Terms");

            migrationBuilder.AlterColumn<string>(
                name: "LinkName",
                table: "Terms",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Terms",
                table: "Terms",
                column: "LinkName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Terms",
                table: "Terms");

            migrationBuilder.AlterColumn<string>(
                name: "LinkName",
                table: "Terms",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Terms",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Terms",
                table: "Terms",
                column: "Id");
        }
    }
}
