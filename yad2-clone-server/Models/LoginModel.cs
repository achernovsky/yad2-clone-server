using System.ComponentModel.DataAnnotations;

namespace yad2_clone_server.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "זה שדה חובה")]
        public string Email { get; set; }

        [Required(ErrorMessage = "זה שדה חובה")]
        public string Password { get; set; }
    }
}

