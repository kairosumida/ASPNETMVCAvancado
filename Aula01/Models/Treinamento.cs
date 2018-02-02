﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula01.Models
{
    public class Treinamento
    {
        public int TreinamentoId { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }

        public virtual ICollection<Matricula> Matriculas { get; set; }
    }
}