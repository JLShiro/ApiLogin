using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLogin.Models
{
    [Table("usuarios")]
    public class Usuarios
    {
        [Key]
        public int id { get; set; }

        [StringLength(20)]
        public string? nombre { get; set; }

        [StringLength(20)]
        public string? apellido { get; set; }

        [StringLength(100)]
        [EmailAddress]
        [Key]
        public string? email { get; set; }

        [StringLength(50)]
        //[DataType(DataType.Password)]
        public string? password { get; set; }
    }
}
