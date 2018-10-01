using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Cits_Base_Center.Migrations
{
    public partial class PMC_SF_SRS_0006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PDBRAND_ID",
                table: "M_PDMODELs",
                unicode: false,
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "SALES_PRICE",
                table: "M_PDMODELs",
                type: "decimal(16, 4)",
                unicode: false,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "UM_NAME",
                table: "M_PDMODELs",
                unicode: false,
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UM_NAME_SALES",
                table: "M_PDMODELs",
                unicode: false,
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "UMQTY_SALES",
                table: "M_PDMODELs",
                type: "decimal(16, 4)",
                unicode: false,
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PDBRAND_ID",
                table: "M_PDMODELs");

            migrationBuilder.DropColumn(
                name: "SALES_PRICE",
                table: "M_PDMODELs");

            migrationBuilder.DropColumn(
                name: "UM_NAME",
                table: "M_PDMODELs");

            migrationBuilder.DropColumn(
                name: "UM_NAME_SALES",
                table: "M_PDMODELs");

            migrationBuilder.DropColumn(
                name: "UMQTY_SALES",
                table: "M_PDMODELs");
        }
    }
}
