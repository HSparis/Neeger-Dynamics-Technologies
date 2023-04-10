using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Neeger_Dynamics_e_Technologies.Data.Migrations
{
    public partial class InsertingDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "Name" },
                values: new object[] { new Guid("c7dce21b-d207-4869-bf5f-08eb138bb919"), "userdefault@neeger.com", "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c7dce21b-d207-4869-bf5f-08eb138bb919"));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
