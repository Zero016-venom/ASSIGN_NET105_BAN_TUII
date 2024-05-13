using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM_NET105_BanTui.Core.Domain.Models
{
    public class GioHang
    {
        [Key]
        public Guid ID_User { get; set; }

        [StringLength(50)]
        public string? TrangThai { get; set; }

        [ForeignKey("ID_User")]
        public virtual ApplicationUser? User { get; set; }

        public virtual ICollection<GioHangCT>? GioHangCTs { get; set; }
    }
}
