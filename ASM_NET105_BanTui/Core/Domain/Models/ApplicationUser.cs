using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ASM_NET105_BanTui.Core.Domain.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? PersonName { get; set; }

        public string? Status { get; set; }

        public virtual ICollection<HoaDon>? Hoadons { get; set; }
        public virtual GioHang? GioHang { get; set; }
    }
}
