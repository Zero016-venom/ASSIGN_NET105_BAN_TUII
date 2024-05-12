using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM_NET105_BanTui.Core.Domain.Models
{
    public class ChuongTrinhKhuyenMai
    {
        [Key]
        public Guid ID_ChuongTrinhKhuyenMai { get; set; }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "Tên chương trình khuyến mại từ 5 đến 100 ký tự")]
        public string? TenChuongTrinhKhuyenMai { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        [StringLength(50)]
        public string? TrangThai { get; set; }
        public Guid? ID_SanPham { get; set; }


        [ForeignKey("ID_SanPham")]
        public virtual SanPham? SanPham { get; set; }
    }
}
