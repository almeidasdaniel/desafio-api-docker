using System.ComponentModel.DataAnnotations;

namespace Stefanini.Domain.Models
{
    public class Cidade : Base
    {
        [Required]
        [MaxLength(200), MinLength(3)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(2), MinLength(2)]
        public string UF { get; set; }
    }
}
