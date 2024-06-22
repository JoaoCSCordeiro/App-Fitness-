using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Utilizador_Autenticado
    {
        [Key]
        public int Id_Util { get; set; }

        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Nome_Autenticado { get; set; }

        public string? Fotografia { get; set; }

        

    }
}
