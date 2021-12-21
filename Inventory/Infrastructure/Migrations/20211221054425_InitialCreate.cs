using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterBarang",
                columns: table => new
                {
                    MasterBarangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamaBarang = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NomorRangka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NomorMesin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Merek = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    KapasitasMesin = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    HargaOff = table.Column<decimal>(type: "money", nullable: true),
                    Bbn = table.Column<decimal>(type: "money", nullable: true),
                    TahunPerakitan = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TypeKendaraan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MasterBarangStatus = table.Column<int>(type: "int", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBarang", x => x.MasterBarangId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterBarang");
        }
    }
}
