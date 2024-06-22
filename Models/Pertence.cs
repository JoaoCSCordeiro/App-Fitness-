using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Pertence
    {
        public DateTime Data_Adesao { get; set; } = DateTime.Now;
        

        [Key]
        public int ID_Pertence { get; set; }
        public Utilizador_Autenticado UtilizadorAutenticado { get; set; }
        public Grupo Grupo { get; set; }
    }

}
