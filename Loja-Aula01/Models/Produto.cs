using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja_Aula01.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
    }
}