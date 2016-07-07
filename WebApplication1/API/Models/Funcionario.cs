using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Funcionario
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage ="O nome do funcionário é obrigatório")]
        [MinLength(3, ErrorMessage = "O tamanho mínimo do nome são 3 caracteres.")]
        [StringLength(255, ErrorMessage = "O tamanho máximo do nome são 255 caracteres.")]
        public string nome { get; set; }

        [Required(ErrorMessage = "O login do funcionário é obrigatório")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo do login são 5 caracteres.")]
        [StringLength(50, ErrorMessage = "O tamanho máximo do login são 50 caracteres.")]
        public string login { get; set; }

        [Required(ErrorMessage = "A senha do funcionário é obrigatória")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo da senha são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo da senha são 200 caracteres.")]
        public string senha { get; set; }
        public DateTime data_nascimento { get; set; }

        [Required(ErrorMessage ="A data de admissão é obrigatória")]
        public DateTime data_admissao { get; set; }

        [Required(ErrorMessage ="O status do funcionário é obrigatório")]
        public bool status { get; set; }
    }
}