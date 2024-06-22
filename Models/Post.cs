using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Post
    {
        [Key]
        [Required]
        public int Id_Post { get; set; }

        [Required]
        public DateTime Data_Post { get; set; } = DateTime.Now;

        [Required]

        public string? Texto { get; set; }

        [Required]
        public Boolean Visibiliade { get; set; } = false;

       


        public Utilizador_Autenticado Utilizador_Autenticado { get; set; }

        


    }
}
