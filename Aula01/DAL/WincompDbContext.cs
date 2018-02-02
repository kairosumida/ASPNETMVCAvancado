using Aula01.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Aula01.DAL
{
    public class WincompDbContext : DbContext
    {
        public WincompDbContext(): base("WincompDbContext") { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Treinamento> Treinamentos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}