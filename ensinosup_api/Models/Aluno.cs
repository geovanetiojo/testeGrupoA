using System.ComponentModel.DataAnnotations;

namespace ensinosup_api.Models
{
    public class Aluno
    {
        [Key]
        public int Ra { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        
    }
}