using Loja_Aula01.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Loja_Aula01.DAL
{
    public class LojaInitializer : DropCreateDatabaseIfModelChanges<LojaDbContext>
    {
        protected override void Seed(LojaDbContext context)
        {
            var produtos = new List<Produto>()
            {
                new Produto(){ProdutoId=1, Descricao="ASP.NET", Preco=500},
                new Produto(){ProdutoId=2, Descricao="Java", Preco=400},
                new Produto(){ProdutoId=3, Descricao="C#", Preco=400}
            };
            produtos.ForEach(s => context.Produtos.Add(s));
            context.SaveChanges();
            var clientes = new List<Cliente>()
            {
                new Cliente{ClienteId=1, Nome="Jõao", Data=DateTime.Parse("2014-02-25")},
                new Cliente{ClienteId=2, Nome="José",  Data=DateTime.Parse("2014-03-26")},
                new Cliente{ClienteId=3, Nome="Maria", Data=DateTime.Parse("2014-04-27")}
            };
            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();
        }
    }
}