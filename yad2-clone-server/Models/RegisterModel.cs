using System.ComponentModel.DataAnnotations;

namespace yad2_clone_server.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "זה שדה חובה")]
        [EmailAddress(ErrorMessage = "מייל לא חוקי")]
        public string Email { get; set; }

        [Required(ErrorMessage = "זה שדה חובה")]
        public string Password { get; set; }
    }
}
