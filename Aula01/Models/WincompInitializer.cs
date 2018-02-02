using Aula01.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula01.Models
{
    public class WincompInitializer : DropCreateDatabaseIfModelChanges<WincompDbContext>
    {
        protected override void Seed(WincompDbContext context)
        {
            var alunos = new List<Aluno>
            {
                new Aluno{AlunoId=1, NomeAluno="Jõao", Email="joao@wincomp.com.br",Data=DateTime.Parse("2014-02-25")},
                new Aluno{AlunoId=2, NomeAluno="José", Email="jose@wincomp.com.br", Data=DateTime.Parse("2014-03-26")},
                new Aluno{AlunoId=3, NomeAluno="Maria", Email="maria@wincomp.com.br", Data=DateTime.Parse("2014-04-27")},
            };
            alunos.ForEach(s => context.Alunos.Add(s));
            context.SaveChanges();
            var treinamentos = new List<Treinamento>
            {
                new Treinamento{TreinamentoId=1, Titulo="C# básico", Creditos=2,},
                new Treinamento{TreinamentoId=2, Titulo="ASP NET Web Forms", Creditos=3,},
                new Treinamento{TreinamentoId=3,Titulo="ASP NET MVC", Creditos=5,},
            };
            treinamentos.ForEach(s => context.Treinamentos.Add(s));
            context.SaveChanges();
            var matriculas = new List<Matricula>
            {
                new Matricula {AlunoId=1, TreinamentoId=1, Grade=Grade.A},
                new Matricula {AlunoId=2, TreinamentoId=2, Grade=Grade.B},
                new Matricula {AlunoId=2, TreinamentoId=1, Grade= Grade.A},
                new Matricula {AlunoId=2, TreinamentoId=2, Grade=Grade.B},
                new Matricula {AlunoId=2, TreinamentoId=3, Grade=Grade.C},
                new Matricula {AlunoId=3, TreinamentoId=3, Grade=Grade.D},
            };
            matriculas.ForEach(s => context.Matriculas.Add(s));
            context.SaveChanges();
        }
    }
}