using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class PedeAcesso
    {
       

        [Key]
        public int ID_PedeAcesso { get; set; }
        public DateTime Data_Pedido { get; set; } = DateTime.Now;
        public DateTime? Data_Resposta { get; set; }
        public string Mensagem { get; set; }
        public bool Resultado { get; set; }

        public Utilizador_Autenticado UtilizadorAutenticado { get; set; }
        public Grupo Grupo { get; set; }
    }

}
