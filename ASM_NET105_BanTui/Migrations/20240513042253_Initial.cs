using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASM_NET105_BanTui.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatLieu",
                columns: table => new
                {
                    ID_ChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChatLieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieu", x => x.ID_ChatLieu);
                });

            migrationBuilder.CreateTable(
                name: "Hang",
                columns: table => new
                {
                    ID_Hang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hang", x => x.ID_Hang);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSP",
                columns: table => new
                {
                    ID_LoaiSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoaiSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSP", x => x.ID_LoaiSP);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    ID_MauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMauSac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.ID_MauSac);
                });

            migrationBuilder.CreateTable(
                name: "PTTT",
                columns: table => new
                {
                    ID_PTTT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenPTTT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PTTT", x => x.ID_PTTT);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID_User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNguoiDung = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID_User);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ID_SanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ID_Hang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    ID_MauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GiaNiemYet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ID_ChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ID_LoaiSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.ID_SanPham);
                    table.ForeignKey(
                        name: "FK_SanPham_ChatLieu_ID_ChatLieu",
                        column: x => x.ID_ChatLieu,
                        principalTable: "ChatLieu",
                        principalColumn: "ID_ChatLieu");
                    table.ForeignKey(
                        name: "FK_SanPham_Hang_ID_Hang",
                        column: x => x.ID_Hang,
                        principalTable: "Hang",
                        principalColumn: "ID_Hang");
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSP_ID_LoaiSP",
                        column: x => x.ID_LoaiSP,
                        principalTable: "LoaiSP",
                        principalColumn: "ID_LoaiSP");
                    table.ForeignKey(
                        name: "FK_SanPham_MauSac_ID_MauSac",
                        column: x => x.ID_MauSac,
                        principalTable: "MauSac",
                        principalColumn: "ID_MauSac");
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    ID_User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.ID_User);
                    table.ForeignKey(
                        name: "FK_GioHang_User_ID_User",
                        column: x => x.ID_User,
                        principalTable: "User",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    ID_HoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_User = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ID_PTTT = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.ID_HoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_PTTT_ID_PTTT",
                        column: x => x.ID_PTTT,
                        principalTable: "PTTT",
                        principalColumn: "ID_PTTT");
                    table.ForeignKey(
                        name: "FK_HoaDon_User_ID_User",
                        column: x => x.ID_User,
                        principalTable: "User",
                        principalColumn: "ID_User");
                });

            migrationBuilder.CreateTable(
                name: "ChuongTrinhKhuyenMai",
                columns: table => new
                {
                    ID_ChuongTrinhKhuyenMai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChuongTrinhKhuyenMai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ID_SanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuongTrinhKhuyenMai", x => x.ID_ChuongTrinhKhuyenMai);
                    table.ForeignKey(
                        name: "FK_ChuongTrinhKhuyenMai_SanPham_ID_SanPham",
                        column: x => x.ID_SanPham,
                        principalTable: "SanPham",
                        principalColumn: "ID_SanPham");
                });

            migrationBuilder.CreateTable(
                name: "GioHangCT",
                columns: table => new
                {
                    ID_GioHangCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    ID_SanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangCT", x => x.ID_GioHangCT);
                    table.ForeignKey(
                        name: "FK_GioHangCT_GioHang_ID_User",
                        column: x => x.ID_User,
                        principalTable: "GioHang",
                        principalColumn: "ID_User",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangCT_SanPham_ID_SanPham",
                        column: x => x.ID_SanPham,
                        principalTable: "SanPham",
                        principalColumn: "ID_SanPham");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCT",
                columns: table => new
                {
                    ID_HoaDonCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_SanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ID_HoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCT", x => x.ID_HoaDonCT);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_HoaDon_ID_HoaDon",
                        column: x => x.ID_HoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "ID_HoaDon");
                    table.ForeignKey(
                        name: "FK_HoaDonCT_SanPham_ID_SanPham",
                        column: x => x.ID_SanPham,
                        principalTable: "SanPham",
                        principalColumn: "ID_SanPham");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChuongTrinhKhuyenMai_ID_SanPham",
                table: "ChuongTrinhKhuyenMai",
                column: "ID_SanPham");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCT_ID_SanPham",
                table: "GioHangCT",
                column: "ID_SanPham");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCT_ID_User",
                table: "GioHangCT",
                column: "ID_User");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_ID_PTTT",
                table: "HoaDon",
                column: "ID_PTTT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_ID_User",
                table: "HoaDon",
                column: "ID_User");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_ID_HoaDon",
                table: "HoaDonCT",
                column: "ID_HoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_ID_SanPham",
                table: "HoaDonCT",
                column: "ID_SanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_ID_ChatLieu",
                table: "SanPham",
                column: "ID_ChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_ID_Hang",
                table: "SanPham",
                column: "ID_Hang");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_ID_LoaiSP",
                table: "SanPham",
                column: "ID_LoaiSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_ID_MauSac",
                table: "SanPham",
                column: "ID_MauSac");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChuongTrinhKhuyenMai");

            migrationBuilder.DropTable(
                name: "GioHangCT");

            migrationBuilder.DropTable(
                name: "HoaDonCT");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "PTTT");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ChatLieu");

            migrationBuilder.DropTable(
                name: "Hang");

            migrationBuilder.DropTable(
                name: "LoaiSP");

            migrationBuilder.DropTable(
                name: "MauSac");
        }
    }
}
