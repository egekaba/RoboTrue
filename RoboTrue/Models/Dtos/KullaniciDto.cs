using System.ComponentModel.DataAnnotations;

namespace RoboTrue.UI.Models
{
    public class KullaniciDto
    {


        [Required(AllowEmptyStrings = false, ErrorMessage = "Mail Zorunludur.")]

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Şifre Zorunludur.")]

        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        public bool RememberMe { get; set; }


    }
}
