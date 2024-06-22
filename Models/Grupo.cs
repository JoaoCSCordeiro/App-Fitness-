using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Models
{
    public class Grupo
    {
        [Key]
        [Required]
        public int Id_Grupo { get; set; }

        [Required]
        public string? Nome_Grupo { get; set; }

        public string? Descricao { get; set; }

        [Required]
        public bool Acesso { get; set; } = false;

        

        
        public Utilizador_Autenticado Utilizador { get; set; }
    }
}
