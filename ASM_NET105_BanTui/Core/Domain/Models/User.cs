using System.ComponentModel.DataAnnotations;

namespace ASM_NET105_BanTui.Core.Domain.Models
{
    public class User
    {
        [Key]
        public Guid ID_User { get; set; }

        [StringLength(20, MinimumLength = 6, ErrorMessage = "Tên người dùng từ 6 đến 20 ký tự")]
        public string? TenNguoiDung { get; set; }

        [StringLength(20, MinimumLength = 6, ErrorMessage = "Mật khẩu từ 6 đến 20 ký tự")]
        public string? MatKhau { get; set; }

        public virtual ICollection<HoaDon>? Hoadons { get; set; }
    }
}
