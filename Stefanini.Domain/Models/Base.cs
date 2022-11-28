using System.ComponentModel.DataAnnotations;

namespace Stefanini.Domain.Models
{
    public class Base
    {
        [Required]
        [Key]
        public int Id { get; set; }
    }
}
