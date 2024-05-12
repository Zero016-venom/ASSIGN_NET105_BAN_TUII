using System.ComponentModel.DataAnnotations;

namespace ASM_NET105_BanTui.Core.Domain.Models
{
    public class MauSac
    {
        [Key]
        public Guid ID_MauSac { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Tên màu từ 2 đến 50 ký tự !")]
        public string? TenMauSac { get; set; }

        [StringLength(256, ErrorMessage = "Mô tả quá dài (dưới 256 ký tự)")]
        public string? MoTa { get; set; }

        [StringLength(50)]
        public string? TrangThai { get; set; }

        public virtual ICollection<SanPham>? SanPhams { get; set; }
    }
}
