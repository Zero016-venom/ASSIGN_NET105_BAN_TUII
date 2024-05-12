using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM_NET105_BanTui.Core.Domain.Models
{
    public class SanPham
    {
        [Key]
        public Guid ID_SanPham { get; set; }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "Tên sản phẩm từ 5 đến 100 ký tự")]
        public string? TenSanPham { get; set; }

        public Guid? ID_Hang { get; set; }
        public int SoLuongTon { get; set; }
        public Guid? ID_MauSac { get; set; }
        public decimal GiaNiemYet { get; set; }
        public Guid? ID_ChatLieu { get; set; }
        public Guid? ID_LoaiSP { get; set; }
        public string? Img { get; set; }
        [StringLength(50)]
        public string? TrangThai { get; set; }

        [ForeignKey("ID_Hang")]
        public virtual Hang? Hang { get; set; }

        [ForeignKey("ID_MauSac")]
        public virtual MauSac? MauSac { get; set; }

        [ForeignKey("ID_ChatLieu")]
        public virtual ChatLieu? ChatLieu { get; set; }

        [ForeignKey("ID_LoaiSP")]
        public virtual LoaiSP? LoaiSP { get; set; }

        public virtual ICollection<HoaDonCT>? HoaDonCT { get; set; }

        public virtual ICollection<ChuongTrinhKhuyenMai>? ChuongTrinhKhuyenMais { get; set; }
        public virtual ICollection<GioHangCT>? GioHangCT { get; set; }
    }
}
