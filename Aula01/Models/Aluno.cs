using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula01.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public DateTime Data { get; set; }
        public string Email { get; set; }
        public string NomeAluno { get; set; }

        public virtual ICollection<Matricula> Matriculas {get;set;}
    }
}