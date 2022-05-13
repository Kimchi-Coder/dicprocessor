using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DicModels.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atts",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Attribute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atts", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "FormRepresentations",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormRepresentations", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "Vals",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vals", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "WordForms",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordForms", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "Equivalents",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenseUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equivalents", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "Feats",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Att = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Val = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquivalentUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FormRepresentationUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LexicalEntryUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MultimediaUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RelatedFormUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SenseExampleUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SenseRelationUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SenseUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WordFormUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feats", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_Feats_Equivalents_EquivalentUuid",
                        column: x => x.EquivalentUuid,
                        principalTable: "Equivalents",
                        principalColumn: "Uuid");
                    table.ForeignKey(
                        name: "FK_Feats_FormRepresentations_FormRepresentationUuid",
                        column: x => x.FormRepresentationUuid,
                        principalTable: "FormRepresentations",
                        principalColumn: "Uuid");
                    table.ForeignKey(
                        name: "FK_Feats_WordForms_WordFormUuid",
                        column: x => x.WordFormUuid,
                        principalTable: "WordForms",
                        principalColumn: "Uuid");
                });

            migrationBuilder.CreateTable(
                name: "Lemmas",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeatUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lemmas", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_Lemmas_Feats_FeatUuid",
                        column: x => x.FeatUuid,
                        principalTable: "Feats",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lexicons",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeatUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lexicons", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_Lexicons_Feats_FeatUuid",
                        column: x => x.FeatUuid,
                        principalTable: "Feats",
                        principalColumn: "Uuid");
                });

            migrationBuilder.CreateTable(
                name: "LexicalEntries",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LemmaUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WordFormUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Att = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Val = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LexiconUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LexicalEntries", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_LexicalEntries_Lemmas_LemmaUuid",
                        column: x => x.LemmaUuid,
                        principalTable: "Lemmas",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LexicalEntries_Lexicons_LexiconUuid",
                        column: x => x.LexiconUuid,
                        principalTable: "Lexicons",
                        principalColumn: "Uuid");
                    table.ForeignKey(
                        name: "FK_LexicalEntries_WordForms_WordFormUuid",
                        column: x => x.WordFormUuid,
                        principalTable: "WordForms",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatedForms",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LexicalEntryUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedForms", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_RelatedForms_LexicalEntries_LexicalEntryUuid",
                        column: x => x.LexicalEntryUuid,
                        principalTable: "LexicalEntries",
                        principalColumn: "Uuid");
                });

            migrationBuilder.CreateTable(
                name: "Senses",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Att = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Val = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LexicalEntryUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Senses", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_Senses_LexicalEntries_LexicalEntryUuid",
                        column: x => x.LexicalEntryUuid,
                        principalTable: "LexicalEntries",
                        principalColumn: "Uuid");
                });

            migrationBuilder.CreateTable(
                name: "Multimedias",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenseUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multimedias", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_Multimedias_Senses_SenseUuid",
                        column: x => x.SenseUuid,
                        principalTable: "Senses",
                        principalColumn: "Uuid");
                });

            migrationBuilder.CreateTable(
                name: "SenseExamples",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenseUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SenseExamples", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_SenseExamples_Senses_SenseUuid",
                        column: x => x.SenseUuid,
                        principalTable: "Senses",
                        principalColumn: "Uuid");
                });

            migrationBuilder.CreateTable(
                name: "SenseRelations",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenseUuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SenseRelations", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_SenseRelations_Senses_SenseUuid",
                        column: x => x.SenseUuid,
                        principalTable: "Senses",
                        principalColumn: "Uuid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equivalents_SenseUuid",
                table: "Equivalents",
                column: "SenseUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_EquivalentUuid",
                table: "Feats",
                column: "EquivalentUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_FormRepresentationUuid",
                table: "Feats",
                column: "FormRepresentationUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_LexicalEntryUuid",
                table: "Feats",
                column: "LexicalEntryUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_MultimediaUuid",
                table: "Feats",
                column: "MultimediaUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_RelatedFormUuid",
                table: "Feats",
                column: "RelatedFormUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_SenseExampleUuid",
                table: "Feats",
                column: "SenseExampleUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_SenseRelationUuid",
                table: "Feats",
                column: "SenseRelationUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_SenseUuid",
                table: "Feats",
                column: "SenseUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_WordFormUuid",
                table: "Feats",
                column: "WordFormUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Lemmas_FeatUuid",
                table: "Lemmas",
                column: "FeatUuid");

            migrationBuilder.CreateIndex(
                name: "IX_LexicalEntries_LemmaUuid",
                table: "LexicalEntries",
                column: "LemmaUuid");

            migrationBuilder.CreateIndex(
                name: "IX_LexicalEntries_LexiconUuid",
                table: "LexicalEntries",
                column: "LexiconUuid");

            migrationBuilder.CreateIndex(
                name: "IX_LexicalEntries_WordFormUuid",
                table: "LexicalEntries",
                column: "WordFormUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Lexicons_FeatUuid",
                table: "Lexicons",
                column: "FeatUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Multimedias_SenseUuid",
                table: "Multimedias",
                column: "SenseUuid");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedForms_LexicalEntryUuid",
                table: "RelatedForms",
                column: "LexicalEntryUuid");

            migrationBuilder.CreateIndex(
                name: "IX_SenseExamples_SenseUuid",
                table: "SenseExamples",
                column: "SenseUuid");

            migrationBuilder.CreateIndex(
                name: "IX_SenseRelations_SenseUuid",
                table: "SenseRelations",
                column: "SenseUuid");

            migrationBuilder.CreateIndex(
                name: "IX_Senses_LexicalEntryUuid",
                table: "Senses",
                column: "LexicalEntryUuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Equivalents_Senses_SenseUuid",
                table: "Equivalents",
                column: "SenseUuid",
                principalTable: "Senses",
                principalColumn: "Uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_LexicalEntries_LexicalEntryUuid",
                table: "Feats",
                column: "LexicalEntryUuid",
                principalTable: "LexicalEntries",
                principalColumn: "Uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_Multimedias_MultimediaUuid",
                table: "Feats",
                column: "MultimediaUuid",
                principalTable: "Multimedias",
                principalColumn: "Uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_RelatedForms_RelatedFormUuid",
                table: "Feats",
                column: "RelatedFormUuid",
                principalTable: "RelatedForms",
                principalColumn: "Uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_SenseExamples_SenseExampleUuid",
                table: "Feats",
                column: "SenseExampleUuid",
                principalTable: "SenseExamples",
                principalColumn: "Uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_SenseRelations_SenseRelationUuid",
                table: "Feats",
                column: "SenseRelationUuid",
                principalTable: "SenseRelations",
                principalColumn: "Uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_Senses_SenseUuid",
                table: "Feats",
                column: "SenseUuid",
                principalTable: "Senses",
                principalColumn: "Uuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equivalents_Senses_SenseUuid",
                table: "Equivalents");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_Senses_SenseUuid",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Multimedias_Senses_SenseUuid",
                table: "Multimedias");

            migrationBuilder.DropForeignKey(
                name: "FK_SenseExamples_Senses_SenseUuid",
                table: "SenseExamples");

            migrationBuilder.DropForeignKey(
                name: "FK_SenseRelations_Senses_SenseUuid",
                table: "SenseRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_Equivalents_EquivalentUuid",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_FormRepresentations_FormRepresentationUuid",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_LexicalEntries_LexicalEntryUuid",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedForms_LexicalEntries_LexicalEntryUuid",
                table: "RelatedForms");

            migrationBuilder.DropTable(
                name: "Atts");

            migrationBuilder.DropTable(
                name: "Vals");

            migrationBuilder.DropTable(
                name: "Senses");

            migrationBuilder.DropTable(
                name: "Equivalents");

            migrationBuilder.DropTable(
                name: "FormRepresentations");

            migrationBuilder.DropTable(
                name: "LexicalEntries");

            migrationBuilder.DropTable(
                name: "Lemmas");

            migrationBuilder.DropTable(
                name: "Lexicons");

            migrationBuilder.DropTable(
                name: "Feats");

            migrationBuilder.DropTable(
                name: "Multimedias");

            migrationBuilder.DropTable(
                name: "RelatedForms");

            migrationBuilder.DropTable(
                name: "SenseExamples");

            migrationBuilder.DropTable(
                name: "SenseRelations");

            migrationBuilder.DropTable(
                name: "WordForms");
        }
    }
}
