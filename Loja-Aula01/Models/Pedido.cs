using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja_Aula01.Models
{
    public class Pedido
    {//um pedido pode ter 1 cliente e 1 produto
        public int PedidoId { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }

        //public virtual ICollection<Produto> Produtos { get; set; }
    }
}