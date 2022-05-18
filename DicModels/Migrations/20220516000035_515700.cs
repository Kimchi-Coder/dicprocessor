using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DicModels.Migrations
{
    public partial class _515700 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lemmas_Feats_FeatUuid",
                table: "Lemmas");

            migrationBuilder.DropForeignKey(
                name: "FK_LexicalEntries_Lemmas_LemmaUuid",
                table: "LexicalEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_LexicalEntries_WordForms_WordFormUuid",
                table: "LexicalEntries");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Vals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "WordFormUuid",
                table: "LexicalEntries",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Val",
                table: "LexicalEntries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "LemmaUuid",
                table: "LexicalEntries",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Att",
                table: "LexicalEntries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "FeatUuid",
                table: "Lemmas",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Lemmas_Feats_FeatUuid",
                table: "Lemmas",
                column: "FeatUuid",
                principalTable: "Feats",
                principalColumn: "Uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_LexicalEntries_Lemmas_LemmaUuid",
                table: "LexicalEntries",
                column: "LemmaUuid",
                principalTable: "Lemmas",
                principalColumn: "Uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_LexicalEntries_WordForms_WordFormUuid",
                table: "LexicalEntries",
                column: "WordFormUuid",
                principalTable: "WordForms",
                principalColumn: "Uuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lemmas_Feats_FeatUuid",
                table: "Lemmas");

            migrationBuilder.DropForeignKey(
                name: "FK_LexicalEntries_Lemmas_LemmaUuid",
                table: "LexicalEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_LexicalEntries_WordForms_WordFormUuid",
                table: "LexicalEntries");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Vals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "WordFormUuid",
                table: "LexicalEntries",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Val",
                table: "LexicalEntries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "LemmaUuid",
                table: "LexicalEntries",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Att",
                table: "LexicalEntries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FeatUuid",
                table: "Lemmas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lemmas_Feats_FeatUuid",
                table: "Lemmas",
                column: "FeatUuid",
                principalTable: "Feats",
                principalColumn: "Uuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LexicalEntries_Lemmas_LemmaUuid",
                table: "LexicalEntries",
                column: "LemmaUuid",
                principalTable: "Lemmas",
                principalColumn: "Uuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LexicalEntries_WordForms_WordFormUuid",
                table: "LexicalEntries",
                column: "WordFormUuid",
                principalTable: "WordForms",
                principalColumn: "Uuid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
