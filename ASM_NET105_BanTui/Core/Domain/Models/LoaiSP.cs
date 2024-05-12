using System.ComponentModel.DataAnnotations;

namespace ASM_NET105_BanTui.Core.Domain.Models
{
    public class LoaiSP
    {
        [Key]
        public Guid ID_LoaiSP { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên loại sản phẩm từ 3 đến 50 ký tự")]
        public string? TenLoaiSP { get; set; }

        [StringLength(100, ErrorMessage = "Mô tả dưới 100 ký tự")]
        public string? MoTa { get; set; }

        [StringLength(50)]
        public string? TrangThai { get; set; }

        public virtual ICollection<SanPham>? SanPhams { get; set; }
    }
}