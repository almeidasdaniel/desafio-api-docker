using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stefanini.Domain.Models
{
    public class Pessoa : Base
    {
        [Required]
        [MaxLength(200), MinLength(3)]        
        public string Nome { get; set; }

        [Required]
        [MaxLength(11), MinLength(11)]
        public string Cpf { get; set; }

        [Required]
        [ForeignKey("Cidade")]
        public int  CidadeId { get; set; }
        public Cidade Cidade { get; set; }

        [Required]
        public int Idade { get; set;}
    }
}
