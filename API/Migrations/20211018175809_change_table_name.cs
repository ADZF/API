using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class change_table_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Tb_M_Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_M_Employees",
                table: "Tb_M_Employees",
                column: "NIK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_M_Employees",
                table: "Tb_M_Employees");

            migrationBuilder.RenameTable(
                name: "Tb_M_Employees",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "NIK");
        }
    }
}
