using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brand_BrandID",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Colors_ColorID",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ColorID",
                table: "Colors",
                newName: "ColorId");

            migrationBuilder.RenameColumn(
                name: "ColorID",
                table: "Cars",
                newName: "ColorId");

            migrationBuilder.RenameColumn(
                name: "BrandID",
                table: "Cars",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_ColorID",
                table: "Cars",
                newName: "IX_Cars_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BrandID",
                table: "Cars",
                newName: "IX_Cars_BrandId");

            migrationBuilder.RenameColumn(
                name: "BrandID",
                table: "Brand",
                newName: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brand_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Colors_ColorId",
                table: "Cars",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brand_BrandId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Colors_ColorId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "Colors",
                newName: "ColorID");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "Cars",
                newName: "ColorID");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Cars",
                newName: "BrandID");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                newName: "IX_Cars_ColorID");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                newName: "IX_Cars_BrandID");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Brand",
                newName: "BrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brand_BrandID",
                table: "Cars",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Colors_ColorID",
                table: "Cars",
                column: "ColorID",
                principalTable: "Colors",
                principalColumn: "ColorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
