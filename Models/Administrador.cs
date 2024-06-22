using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Administrador
    {
        [Key]
        [Required]
        public int Id_Admin { get; set; }
     

        [Required]
        public string? Nome_Admin { get; set; }

        

    }
}
