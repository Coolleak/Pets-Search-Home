using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.EF.Migrations
{
    public partial class AddedAnimalColorsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorRecord_Animals_AnimalRecordId",
                table: "ColorRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorRecord",
                table: "ColorRecord");

            migrationBuilder.RenameTable(
                name: "ColorRecord",
                newName: "AnimalColors");

            migrationBuilder.RenameIndex(
                name: "IX_ColorRecord_AnimalRecordId",
                table: "AnimalColors",
                newName: "IX_AnimalColors_AnimalRecordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalColors",
                table: "AnimalColors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalColors_Animals_AnimalRecordId",
                table: "AnimalColors",
                column: "AnimalRecordId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalColors_Animals_AnimalRecordId",
                table: "AnimalColors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalColors",
                table: "AnimalColors");

            migrationBuilder.RenameTable(
                name: "AnimalColors",
                newName: "ColorRecord");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalColors_AnimalRecordId",
                table: "ColorRecord",
                newName: "IX_ColorRecord_AnimalRecordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorRecord",
                table: "ColorRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ColorRecord_Animals_AnimalRecordId",
                table: "ColorRecord",
                column: "AnimalRecordId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
