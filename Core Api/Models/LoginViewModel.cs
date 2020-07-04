
using System.ComponentModel.DataAnnotations;

namespace Net_Core_Swagger_Implementation.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
