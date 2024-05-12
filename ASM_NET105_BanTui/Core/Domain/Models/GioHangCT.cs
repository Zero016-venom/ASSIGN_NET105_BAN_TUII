using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM_NET105_BanTui.Core.Domain.Models
{
    public class GioHangCT
    {
        [Key]
        public Guid ID_GioHangCT { get; set; }
        public Guid ID_User { get; set; }
        public int SoLuong { get; set; }
        public Guid? ID_SanPham { get; set; }

        [ForeignKey("ID_SanPham")]
        public virtual SanPham? SanPham { get; set; }

        [ForeignKey("ID_User")]
        public virtual GioHang? GioHang { get; set; }


    }
}