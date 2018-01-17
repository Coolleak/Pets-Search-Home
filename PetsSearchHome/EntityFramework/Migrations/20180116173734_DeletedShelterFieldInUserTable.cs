using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.EF.Migrations
{
    public partial class DeletedShelterFieldInUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Shelter_ShelterId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ShelterId",
                table: "Users",
                newName: "ShelterRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ShelterId",
                table: "Users",
                newName: "IX_Users_ShelterRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Shelter_ShelterRecordId",
                table: "Users",
                column: "ShelterRecordId",
                principalTable: "Shelter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Shelter_ShelterRecordId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ShelterRecordId",
                table: "Users",
                newName: "ShelterId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ShelterRecordId",
                table: "Users",
                newName: "IX_Users_ShelterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Shelter_ShelterId",
                table: "Users",
                column: "ShelterId",
                principalTable: "Shelter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
