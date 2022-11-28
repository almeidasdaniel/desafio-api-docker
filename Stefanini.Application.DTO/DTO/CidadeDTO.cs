using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Stefanini.Application.DTO.DTO
{
    public class CidadeDTO 
    {
        [Required]
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200), MinLength(3)]
        public string Nome { get; set;}

        [Required]
        [MaxLength(2), MinLength(2)]
        public string UF { get; set; }
    }
}
