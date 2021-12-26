using Microsoft.EntityFrameworkCore.Migrations;

namespace BM_Medical.Data.Migrations
{
    public partial class BM_Tablolar4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_ProductDetails_ProductDetailId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_UrunId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Carts_UrunId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_KategoriId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_Products_KategoriId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Images_ProductDetailId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_UrunId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDetailId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UrunId",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "UrunId",
                table: "Products",
                newName: "ImageId");

            migrationBuilder.RenameColumn(
                name: "Adet",
                table: "Products",
                newName: "Stok");

            migrationBuilder.RenameIndex(
                name: "IX_Products_UrunId",
                table: "Products",
                newName: "IX_Products_ImageId");

            migrationBuilder.RenameColumn(
                name: "UrunId",
                table: "Carts",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Fiyat",
                table: "Carts",
                newName: "LastFiyat");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartStatuId",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CartStatu",
                columns: table => new
                {
                    CartStatuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartStatu", x => x.CartStatuId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CartId",
                table: "Orders",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CartStatuId",
                table: "Carts",
                column: "CartStatuId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_CartStatu_CartStatuId",
                table: "Carts",
                column: "CartStatuId",
                principalTable: "CartStatu",
                principalColumn: "CartStatuId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Carts_CartId",
                table: "Orders",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Images_ImageId",
                table: "Products",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_CartStatu_CartStatuId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Carts_CartId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Images_ImageId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "CartStatu");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CartId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Carts_CartStatuId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_ProductId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CartStatuId",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "Stok",
                table: "Products",
                newName: "Adet");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "Products",
                newName: "UrunId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ImageId",
                table: "Products",
                newName: "IX_Products_UrunId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Carts",
                newName: "UrunId");

            migrationBuilder.RenameColumn(
                name: "LastFiyat",
                table: "Carts",
                newName: "Fiyat");

            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductDetailId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UrunId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    Stok = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_KategoriId",
                table: "Products",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductDetailId",
                table: "Images",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_UrunId",
                table: "Images",
                column: "UrunId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ProductDetails_ProductDetailId",
                table: "Images",
                column: "ProductDetailId",
                principalTable: "ProductDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_UrunId",
                table: "Images",
                column: "UrunId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Carts_UrunId",
                table: "Products",
                column: "UrunId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_KategoriId",
                table: "Products",
                column: "KategoriId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
