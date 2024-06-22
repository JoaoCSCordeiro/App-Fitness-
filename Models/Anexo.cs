using System.ComponentModel.DataAnnotations;

namespace Projeto.Models

{
    public class Anexo
    {
        [Key]
        [Required]
        public int Id_Anexo { get; set; }

        [Required]
        public string? Nome_Anexo { get; set; }

        [Required]
        public string? Tipo {  get; set; }

        [Required]
        public string? URL_Anexo { get; set; }



        [Required]

       


        public Post Post { get; set; }

        
    }
}
