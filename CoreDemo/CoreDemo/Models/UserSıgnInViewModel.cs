using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSıgnInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
        public string username { get; set; }
        
        [Required(ErrorMessage = "Lütfen Şifrenizi  Girin")]
        public string password { get; set; }
    }
}
