using System.ComponentModel.DataAnnotations;

namespace ASM_NET105_BanTui.Core.Domain.Models
{
    public class PTTT
    {
        [Key]
        public Guid ID_PTTT { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Tên phương thức thanh toán từ 2 đến 50 ký tự")]
        public string? TenPTTT { get; set; }

        [StringLength(100, ErrorMessage = "Mô tả dưới 100 ký tự")]
        public string? MoTa { get; set; }

        [StringLength(50)]
        public string? TrangThai { get; set; }

        public virtual ICollection<HoaDon>? HoaDons { get; set; }
    }
}