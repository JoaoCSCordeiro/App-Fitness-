using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Partilha
    {
        
       

        [Key]
        public int ID_Partilha { get; set; }
        public Grupo Grupo { get; set; }
        public Ficheiro Ficheiro { get; set; }
    }

}
