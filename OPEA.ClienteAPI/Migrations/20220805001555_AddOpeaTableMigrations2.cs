using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OPEA.ClienteAPI.Migrations
{
    public partial class AddOpeaTableMigrations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_TipoEmpresas_TipoEmpresaId",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "TipoEmpresaId",
                table: "Clientes",
                newName: "tipo_empresa_id");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_TipoEmpresaId",
                table: "Clientes",
                newName: "IX_Clientes_tipo_empresa_id");

            migrationBuilder.AlterColumn<int>(
                name: "tipo_empresa_id",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_TipoEmpresas_tipo_empresa_id",
                table: "Clientes",
                column: "tipo_empresa_id",
                principalTable: "TipoEmpresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_TipoEmpresas_tipo_empresa_id",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "tipo_empresa_id",
                table: "Clientes",
                newName: "TipoEmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_tipo_empresa_id",
                table: "Clientes",
                newName: "IX_Clientes_TipoEmpresaId");

            migrationBuilder.AlterColumn<int>(
                name: "TipoEmpresaId",
                table: "Clientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_TipoEmpresas_TipoEmpresaId",
                table: "Clientes",
                column: "TipoEmpresaId",
                principalTable: "TipoEmpresas",
                principalColumn: "Id");
        }
    }
}
