using Microsoft.EntityFrameworkCore.Migrations;

namespace Veterinaria.App.Persistencia.Migrations
{
    public partial class adicion_interrogacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_Cita_CitaId",
                table: "Mascota");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_HistorialClinico_IdHistoriaClinica",
                table: "Mascota");

            migrationBuilder.DropIndex(
                name: "IX_Mascota_CitaId",
                table: "Mascota");

            migrationBuilder.DropColumn(
                name: "CitaId",
                table: "Mascota");

            migrationBuilder.AlterColumn<int>(
                name: "IdVeterinario",
                table: "Mascota",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdHistoriaClinica",
                table: "Mascota",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdCita",
                table: "Mascota",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_IdCita",
                table: "Mascota",
                column: "IdCita");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_Cita_IdCita",
                table: "Mascota",
                column: "IdCita",
                principalTable: "Cita",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_HistorialClinico_IdHistoriaClinica",
                table: "Mascota",
                column: "IdHistoriaClinica",
                principalTable: "HistorialClinico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_Cita_IdCita",
                table: "Mascota");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_HistorialClinico_IdHistoriaClinica",
                table: "Mascota");

            migrationBuilder.DropIndex(
                name: "IX_Mascota_IdCita",
                table: "Mascota");

            migrationBuilder.AlterColumn<int>(
                name: "IdVeterinario",
                table: "Mascota",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdHistoriaClinica",
                table: "Mascota",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdCita",
                table: "Mascota",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CitaId",
                table: "Mascota",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_CitaId",
                table: "Mascota",
                column: "CitaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_Cita_CitaId",
                table: "Mascota",
                column: "CitaId",
                principalTable: "Cita",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_HistorialClinico_IdHistoriaClinica",
                table: "Mascota",
                column: "IdHistoriaClinica",
                principalTable: "HistorialClinico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
