using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Ficheiro
    {
        [Key]
        [Required]
        public int Id_Ficheiro { get; set; }

        [Required]
        public string? Local_Armazenamento { get; set; }

        [Required]
        public DateTime Data_Ficheiro {  get; set; } = DateTime.Now;

       
        public Utilizador_Autenticado Utilizador_Autenticado { get; set; }


    }
}
