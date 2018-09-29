using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiapWeb.Model
{
    public class Pergunta
    {
        public Pergunta()
        {
        }

        public Pergunta(int Id, string _Descricao, string _Aluno)
        {
             new Pergunta() { id = Id, Descricao = _Descricao, Aluno = _Aluno };
        }

        [Required]
        public int id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Aluno { get; set; }
    }
}
