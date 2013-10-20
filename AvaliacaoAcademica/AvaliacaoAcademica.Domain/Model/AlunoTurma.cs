namespace AvaliacaoAcademica.Domain.Model
{
   public class AlunoTurma
    {
       public virtual int Id { get; set; }
       public virtual Turma Turma { get; set; }
       public virtual Aluno Aluno { get; set; }
    }
}
