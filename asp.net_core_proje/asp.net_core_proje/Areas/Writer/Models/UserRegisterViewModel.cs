using System.ComponentModel.DataAnnotations;

namespace asp.net_core_proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen E-mail adresinizi girin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen şifre girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifre girin")]
        [Compare("Password",ErrorMessage = "Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }

    }
}
