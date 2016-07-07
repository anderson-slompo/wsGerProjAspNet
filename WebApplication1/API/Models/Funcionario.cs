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
        [MinLength(5, ErrorMessage = "O tamanho mínimo do nome são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo do nome são 255 caracteres.")]
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public DateTime data_nascimento { get; set; }
        public DateTime data_admissao { get; set; }
        public bool status { get; set; }
    }
}