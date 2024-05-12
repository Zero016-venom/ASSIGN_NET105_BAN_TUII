using System;
using System.Reflection;
using ASM_NET105_BanTui.Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ASM_NET105_BanTui.Infrastructure.DatabaseContext
{
	public class AppDbContext : DbContext
	{
		public AppDbContext()
		{
		}

        public DbSet<ChatLieu> ChatLieu { get; set; }
        public DbSet<ChuongTrinhKhuyenMai> ChuongTrinhKhuyenMai { get; set; }
        public DbSet<GioHang> GioHang { get; set; }
        public DbSet<GioHangCT> GioHangCT { get; set; }
        public DbSet<Hang> Hang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDonCT> HoaDonCT { get; set; }
        public DbSet<LoaiSP> LoaiSP { get; set; }
        public DbSet<MauSac> MauSac { get; set; }
        public DbSet<PTTT> PTTT { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KHAI-PC;Database=NET105_ASM;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

