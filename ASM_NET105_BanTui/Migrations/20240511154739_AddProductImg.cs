using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASM_NET105_BanTui.Migrations
{
    /// <inheritdoc />
    public partial class AddProductImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "SanPham");
        }
    }
}
