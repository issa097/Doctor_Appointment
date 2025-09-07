using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorAppointment.Data.Migrations
{
    /// <inheritdoc />
    public partial class mmjl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_doctors_DoctorsId",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_patients_PatientsId",
                table: "appointments");

            migrationBuilder.RenameColumn(
                name: "PatientsId",
                table: "appointments",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "DoctorsId",
                table: "appointments",
                newName: "DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_PatientsId",
                table: "appointments",
                newName: "IX_appointments_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_DoctorsId",
                table: "appointments",
                newName: "IX_appointments_DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_doctors_DoctorId",
                table: "appointments",
                column: "DoctorId",
                principalTable: "doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_patients_PatientId",
                table: "appointments",
                column: "PatientId",
                principalTable: "patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_doctors_DoctorId",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_patients_PatientId",
                table: "appointments");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "appointments",
                newName: "PatientsId");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "appointments",
                newName: "DoctorsId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_PatientId",
                table: "appointments",
                newName: "IX_appointments_PatientsId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_DoctorId",
                table: "appointments",
                newName: "IX_appointments_DoctorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_doctors_DoctorsId",
                table: "appointments",
                column: "DoctorsId",
                principalTable: "doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_patients_PatientsId",
                table: "appointments",
                column: "PatientsId",
                principalTable: "patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
