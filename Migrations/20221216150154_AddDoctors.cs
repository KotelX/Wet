using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wet.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnozs_Patients_PatientId",
                table: "Diagnozs");

            migrationBuilder.DropForeignKey(
                name: "FK_Simptoms_Patients_PatientId",
                table: "Simptoms");

            migrationBuilder.DropIndex(
                name: "IX_Simptoms_PatientId",
                table: "Simptoms");

            migrationBuilder.DropIndex(
                name: "IX_Diagnozs_PatientId",
                table: "Diagnozs");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Simptoms");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Diagnozs");

            migrationBuilder.AddColumn<int>(
                name: "VisitingId",
                table: "Simptoms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Patients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Breed",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OwnerEmail",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerPhone",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerSurname",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VisitingId",
                table: "Diagnozs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Simptoms_VisitingId",
                table: "Simptoms",
                column: "VisitingId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnozs_VisitingId",
                table: "Diagnozs",
                column: "VisitingId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_DoctorId",
                table: "Visits",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_PatientId",
                table: "Visits",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnozs_Visits_VisitingId",
                table: "Diagnozs",
                column: "VisitingId",
                principalTable: "Visits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_DoctorId",
                table: "Patients",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Simptoms_Visits_VisitingId",
                table: "Simptoms",
                column: "VisitingId",
                principalTable: "Visits",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnozs_Visits_VisitingId",
                table: "Diagnozs");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_DoctorId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Simptoms_Visits_VisitingId",
                table: "Simptoms");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Simptoms_VisitingId",
                table: "Simptoms");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Diagnozs_VisitingId",
                table: "Diagnozs");

            migrationBuilder.DropColumn(
                name: "VisitingId",
                table: "Simptoms");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "OwnerEmail",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "OwnerPhone",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "OwnerSurname",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "VisitingId",
                table: "Diagnozs");

            migrationBuilder.AddColumn<long>(
                name: "PatientId",
                table: "Simptoms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PatientId",
                table: "Diagnozs",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Simptoms_PatientId",
                table: "Simptoms",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnozs_PatientId",
                table: "Diagnozs",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnozs_Patients_PatientId",
                table: "Diagnozs",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Simptoms_Patients_PatientId",
                table: "Simptoms",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");
        }
    }
}
