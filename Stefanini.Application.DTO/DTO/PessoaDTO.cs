using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stefanini.Application.DTO.DTO
{
    public class PessoaDTO
    {
        [Required]
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(300), MinLength(3)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(11), MinLength(11)]
        public string Cpf { get; set; }

        [Required]
        [ForeignKey("CidadeDTO")]
        public int CidadeId { get; set; }
        [Required]
        public int Idade { get; set; }

    }
}
