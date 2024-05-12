﻿// <auto-generated />
using System;
using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASM_NET105_BanTui.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.IdentityEntities.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.IdentityEntities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.ChatLieu", b =>
                {
                    b.Property<Guid>("ID_ChatLieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenChatLieu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_ChatLieu");

                    b.ToTable("ChatLieu");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.ChuongTrinhKhuyenMai", b =>
                {
                    b.Property<Guid>("ID_ChuongTrinhKhuyenMai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ID_SanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenChuongTrinhKhuyenMai")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_ChuongTrinhKhuyenMai");

                    b.HasIndex("ID_SanPham");

                    b.ToTable("ChuongTrinhKhuyenMai");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.GioHang", b =>
                {
                    b.Property<Guid>("ID_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_User");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.GioHangCT", b =>
                {
                    b.Property<Guid>("ID_GioHangCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ID_SanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("ID_GioHangCT");

                    b.HasIndex("ID_SanPham");

                    b.HasIndex("ID_User");

                    b.ToTable("GioHangCT");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.Hang", b =>
                {
                    b.Property<Guid>("ID_Hang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenHang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_Hang");

                    b.ToTable("Hang");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.HoaDon", b =>
                {
                    b.Property<Guid>("ID_HoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ID_PTTT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ID_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_HoaDon");

                    b.HasIndex("ID_PTTT");

                    b.HasIndex("ID_User");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.HoaDonCT", b =>
                {
                    b.Property<Guid>("ID_HoaDonCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("ID_HoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ID_SanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("ID_HoaDonCT");

                    b.HasIndex("ID_HoaDon");

                    b.HasIndex("ID_SanPham");

                    b.ToTable("HoaDonCT");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.LoaiSP", b =>
                {
                    b.Property<Guid>("ID_LoaiSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenLoaiSP")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_LoaiSP");

                    b.ToTable("LoaiSP");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.MauSac", b =>
                {
                    b.Property<Guid>("ID_MauSac")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TenMauSac")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_MauSac");

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.PTTT", b =>
                {
                    b.Property<Guid>("ID_PTTT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenPTTT")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_PTTT");

                    b.ToTable("PTTT");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.SanPham", b =>
                {
                    b.Property<Guid>("ID_SanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaNiemYet")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("ID_ChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ID_Hang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ID_LoaiSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ID_MauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TrangThai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_SanPham");

                    b.HasIndex("ID_ChatLieu");

                    b.HasIndex("ID_Hang");

                    b.HasIndex("ID_LoaiSP");

                    b.HasIndex("ID_MauSac");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.User", b =>
                {
                    b.Property<Guid>("ID_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TenNguoiDung")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID_User");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.ChuongTrinhKhuyenMai", b =>
                {
                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.SanPham", "SanPham")
                        .WithMany("ChuongTrinhKhuyenMais")
                        .HasForeignKey("ID_SanPham");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.GioHang", b =>
                {
                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("ID_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.GioHangCT", b =>
                {
                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.SanPham", "SanPham")
                        .WithMany("GioHangCT")
                        .HasForeignKey("ID_SanPham");

                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.GioHang", "GioHang")
                        .WithMany("GioHangCTs")
                        .HasForeignKey("ID_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.HoaDon", b =>
                {
                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.PTTT", "PTTT")
                        .WithMany("HoaDons")
                        .HasForeignKey("ID_PTTT");

                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.User", "User")
                        .WithMany("Hoadons")
                        .HasForeignKey("ID_User");

                    b.Navigation("PTTT");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.HoaDonCT", b =>
                {
                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.HoaDon", "HoaDons")
                        .WithMany("HoaDonCT")
                        .HasForeignKey("ID_HoaDon");

                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.SanPham", "SanPham")
                        .WithMany("HoaDonCT")
                        .HasForeignKey("ID_SanPham");

                    b.Navigation("HoaDons");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.SanPham", b =>
                {
                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.ChatLieu", "ChatLieu")
                        .WithMany("SanPhams")
                        .HasForeignKey("ID_ChatLieu");

                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.Hang", "Hang")
                        .WithMany("SanPham")
                        .HasForeignKey("ID_Hang");

                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.LoaiSP", "LoaiSP")
                        .WithMany("SanPhams")
                        .HasForeignKey("ID_LoaiSP");

                    b.HasOne("ASM_NET105_BanTui.Core.Domain.Models.MauSac", "MauSac")
                        .WithMany("SanPhams")
                        .HasForeignKey("ID_MauSac");

                    b.Navigation("ChatLieu");

                    b.Navigation("Hang");

                    b.Navigation("LoaiSP");

                    b.Navigation("MauSac");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("ASM_NET105_BanTui.Core.Domain.IdentityEntities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ASM_NET105_BanTui.Core.Domain.IdentityEntities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ASM_NET105_BanTui.Core.Domain.IdentityEntities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("ASM_NET105_BanTui.Core.Domain.IdentityEntities.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM_NET105_BanTui.Core.Domain.IdentityEntities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ASM_NET105_BanTui.Core.Domain.IdentityEntities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.ChatLieu", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.GioHang", b =>
                {
                    b.Navigation("GioHangCTs");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.Hang", b =>
                {
                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonCT");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.LoaiSP", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.MauSac", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.PTTT", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.SanPham", b =>
                {
                    b.Navigation("ChuongTrinhKhuyenMais");

                    b.Navigation("GioHangCT");

                    b.Navigation("HoaDonCT");
                });

            modelBuilder.Entity("ASM_NET105_BanTui.Core.Domain.Models.User", b =>
                {
                    b.Navigation("Hoadons");
                });
#pragma warning restore 612, 618
        }
    }
}
