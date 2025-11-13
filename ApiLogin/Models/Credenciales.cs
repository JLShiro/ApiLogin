using System.ComponentModel.DataAnnotations;

namespace ApiLogin.Models
{
    public class Credenciales
    {
        [Required]
        public string? email { get; set; }
        [Required]
        public string? password { get; set; }
    }
}
