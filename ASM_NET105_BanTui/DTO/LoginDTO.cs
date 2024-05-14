using System.ComponentModel.DataAnnotations;

namespace ASM_NET105_BanTui.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email không được để trống !")]
        [EmailAddress(ErrorMessage = "Email phải hợp lệ !")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống !")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
