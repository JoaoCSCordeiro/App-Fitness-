using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Comenta
    {
       

        [Key]

        public int ID_Comenta { get; set; }
        public DateTime Data_Comentario { get; set; } = DateTime.Now;
        public string? Texto { get; set; }

        public Utilizador_Autenticado UtilizadorAutenticado { get; set; }
        public Post Post { get; set; }
    }

}
