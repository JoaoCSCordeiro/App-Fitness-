using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class PartilhaGrupo
    {
        

        [Key]
        public int ID_PartilhaGrupo { get; set; }
        public Grupo Grupo { get; set; }
        public Post Post { get; set; }
    }

}
