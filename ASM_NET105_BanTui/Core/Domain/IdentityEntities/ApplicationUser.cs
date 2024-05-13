using Microsoft.AspNetCore.Identity;

namespace ASM_NET105_BanTui.Core.Domain.IdentityEntities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? PersonName { get; set; }
    }
}
