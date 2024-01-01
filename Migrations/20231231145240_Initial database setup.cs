using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorVetClinicPractise1.Migrations
{
    /// <inheritdoc />
    public partial class Initialdatabasesetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalPassports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalPassports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VaccineRegistryEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineRegistryEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veterinarians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinarians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vaccinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalPassportId = table.Column<int>(type: "int", nullable: false),
                    VeterinarianId = table.Column<int>(type: "int", nullable: false),
                    VaccineRegistryEntryId = table.Column<int>(type: "int", nullable: false),
                    VaccinationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaccinations_AnimalPassports_AnimalPassportId",
                        column: x => x.AnimalPassportId,
                        principalTable: "AnimalPassports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vaccinations_VaccineRegistryEntries_VaccineRegistryEntryId",
                        column: x => x.VaccineRegistryEntryId,
                        principalTable: "VaccineRegistryEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vaccinations_Veterinarians_VeterinarianId",
                        column: x => x.VeterinarianId,
                        principalTable: "Veterinarians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AnimalPassports",
                columns: new[] { "Id", "Age", "AnimalType", "Breed", "Gender", "Name" },
                values: new object[] { 1, 11, "Dog", "SomeBreed", "Male", "A Dog" });

            migrationBuilder.InsertData(
                table: "VaccineRegistryEntries",
                columns: new[] { "Id", "ExpiryDate", "SerialNumber", "VaccineName" },
                values: new object[] { 1, new DateTime(2024, 12, 31, 14, 52, 39, 802, DateTimeKind.Utc).AddTicks(4989), "12345", "Vaccine1" });

            migrationBuilder.InsertData(
                table: "Veterinarians",
                columns: new[] { "Id", "FirstName", "LastName", "SocialNumber" },
                values: new object[] { 1, "Luke", "Vader", "12345" });

            migrationBuilder.InsertData(
                table: "Vaccinations",
                columns: new[] { "Id", "AnimalPassportId", "VaccinationDate", "VaccineRegistryEntryId", "VeterinarianId" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 31, 14, 52, 39, 802, DateTimeKind.Utc).AddTicks(5024), 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Vaccinations_AnimalPassportId",
                table: "Vaccinations",
                column: "AnimalPassportId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccinations_VaccineRegistryEntryId",
                table: "Vaccinations",
                column: "VaccineRegistryEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccinations_VeterinarianId",
                table: "Vaccinations",
                column: "VeterinarianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaccinations");

            migrationBuilder.DropTable(
                name: "AnimalPassports");

            migrationBuilder.DropTable(
                name: "VaccineRegistryEntries");

            migrationBuilder.DropTable(
                name: "Veterinarians");
        }
    }
}
