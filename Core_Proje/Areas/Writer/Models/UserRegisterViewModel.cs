using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınızı Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Girin")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Resim Url değeri girin")]
        public string ImageUrl { get; set; }


        [Required(ErrorMessage = "Lütfen şifreyi Girin")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Lütfen şifreyi tekrar Girin")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil!")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Lütfen mail Girin")]
        public string Mail { get; set; }
    }
}
