using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM_NET105_BanTui.Core.Domain.Models
{
    public class HoaDon
    {
        [Key]
        public Guid ID_HoaDon { get; set; }
        public Guid? ID_User { get; set; }
        public decimal TongTien { get; set; }

        [StringLength(50)]
        public string? TrangThai { get; set; }
        public Guid? ID_PTTT { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public virtual ICollection<HoaDonCT>? HoaDonCT { get; set; }

        [ForeignKey("ID_User")]
        public virtual User? User { get; set; }

        [ForeignKey("ID_PTTT")]
        public virtual PTTT? PTTT { get; set; }
    }
}
