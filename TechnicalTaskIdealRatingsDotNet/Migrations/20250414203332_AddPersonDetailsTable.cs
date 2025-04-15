using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechnicalTaskIdealRatingsDotNet.Migrations
{
    /// <inheritdoc />
    public partial class AddPersonDetailsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "TelephoneCode",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person_Details");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Person_Details",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Person_Details",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Person_Details",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TelephoneNumber",
                table: "Person_Details",
                newName: "telephone Number");

            migrationBuilder.AlterColumn<string>(
                name: "country",
                table: "Person_Details",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "Person_Details",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "telephone Number",
                table: "Person_Details",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Person_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person_Details",
                table: "Person_Details",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Person_Details",
                table: "Person_Details");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Person_Details");

            migrationBuilder.RenameTable(
                name: "Person_Details",
                newName: "Persons");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Persons",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Persons",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Persons",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "telephone Number",
                table: "Persons",
                newName: "TelephoneNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelephoneNumber",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TelephoneCode",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");
        }
    }
}
