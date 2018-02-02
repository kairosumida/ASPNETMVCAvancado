namespace Aula01.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public int TreinamentoId { get; set; }
        public int AlunoId { get; set; }
        public Grade? Grade { get; set; }

        public virtual Treinamento Treinamento { get; set; }
        public virtual Aluno Aluno { get; set; }
       
    }
}