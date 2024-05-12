using System.ComponentModel.DataAnnotations;

namespace ASM_NET105_BanTui.Core.Domain.Models
{
    public class Hang
    {
        [Key]
        public Guid ID_Hang { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên hãng từ 3 đến 50 ký tự")]
        public string? TenHang { get; set; }

        [StringLength(100, ErrorMessage = "Mô tả dưới 100 ký tự")]
        public string? MoTa { get; set; }

        [StringLength(50)]
        public string? TrangThai { get; set; }

        public virtual ICollection<SanPham>? SanPham { get; set; }
    }
}