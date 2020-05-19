using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class seedValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "pp31@gmail.com", "Paweł", "Pietrzak" },
                    { 2, "rzepa@gmail.com", "Andrzej", "Rzepka" },
                    { 3, "kkocha@gmail.com", "Joanna", "Koch" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Lek na stany gorączkowe, obnizona odp", "Aspirin", "Pastylki" },
                    { 2, "Na Przeziębienie, ból głowy", "Ibuprom", "Tabletka" },
                    { 3, "Rzucanie Palenia", "Desmoxan", "Plaster" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "Birthday", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1988, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "karol", "Kowalski" },
                    { 2, new DateTime(1996, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jakub", "Jakubowski" },
                    { 3, new DateTime(2000, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paulina", "Jakubowski" },
                    { 4, new DateTime(1946, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piotr", "Wichura" }
                });

            migrationBuilder.InsertData(
                table: "Perscription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "5 razy dziennie przed posilkiem", 5 },
                    { 2, 2, "30 min przed zasnieciem 2 porcje", 2 }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 19, 18, 15, 22, 45, DateTimeKind.Local).AddTicks(6213), new DateTime(2020, 9, 19, 18, 15, 22, 52, DateTimeKind.Local).AddTicks(1865), 1, 1 },
                    { 2, new DateTime(2020, 5, 19, 18, 15, 22, 52, DateTimeKind.Local).AddTicks(3291), new DateTime(2020, 9, 19, 18, 15, 22, 52, DateTimeKind.Local).AddTicks(3322), 1, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Perscription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Perscription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2);
        }
    }
}
