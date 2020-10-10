﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DockerSqlServer.Migrations
{
    public partial class initMssql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Magazine",
                columns: table => new
                {
                    MagazineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazine", x => x.MagazineId);
                });

            migrationBuilder.InsertData(
                table: "Magazine",
                columns: new[] { "MagazineId", "Name" },
                values: new object[] { 1, "MSDN Magazine" });

            migrationBuilder.InsertData(
                table: "Magazine",
                columns: new[] { "MagazineId", "Name" },
                values: new object[] { 2, "Docker Magazine" });

            migrationBuilder.InsertData(
                table: "Magazine",
                columns: new[] { "MagazineId", "Name" },
                values: new object[] { 3, "EFCore Magazine" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Magazine");
        }
    }
}
