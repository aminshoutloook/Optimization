using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Optimization.DataLayer.Migrations
{
    public partial class initialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Production");

            migrationBuilder.CreateTable(
                name: "Project",
                schema: "Production",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cup",
                schema: "Production",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ProjectId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cup_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalSchema: "Production",
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pieces",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ProjectId = table.Column<Guid>(nullable: false),
                    CupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pieces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pieces_Cup_CupId",
                        column: x => x.CupId,
                        principalSchema: "Production",
                        principalTable: "Cup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pieces_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalSchema: "Production",
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_CupId",
                table: "Pieces",
                column: "CupId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_ProjectId",
                table: "Pieces",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Cup_ProjectId",
                schema: "Production",
                table: "Cup",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pieces");

            migrationBuilder.DropTable(
                name: "Cup",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "Project",
                schema: "Production");
        }
    }
}
