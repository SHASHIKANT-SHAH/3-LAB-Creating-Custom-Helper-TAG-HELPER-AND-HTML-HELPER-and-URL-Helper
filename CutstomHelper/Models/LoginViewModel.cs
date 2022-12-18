using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CutstomHelper.Models
{
    public class LoginViewModel
    {
        [Required]
        [Column(TypeName ="varchar(100")]
        public string Username { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }
    }
}
