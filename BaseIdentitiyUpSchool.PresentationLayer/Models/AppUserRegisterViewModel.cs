using System.ComponentModel.DataAnnotations;

namespace BaseIdentitiyUpSchool.PresentationLayer.Models
{
    public class AppUserRegisterViewModel
    {
        [Required(ErrorMessage ="kullanıcı adı boş geçilemez")]

        public string Username { get; set; }

        [Required(ErrorMessage = "ad boş geçilemez")]

        public string Name { get; set; }

        [Required(ErrorMessage = "soyad boş geçilemez")]

        public string Surname { get; set; }

        [Required(ErrorMessage = "mail boş geçilemez")]

        public string Mail { get; set; }

        [Required(ErrorMessage = "şifre boş geçilemez")]

        public string Password { get; set; }


        [Required(ErrorMessage = "şifre tekrar boş geçilemez")]

        public string ConfirmPassword { get; set; }    

    }
}
