namespace AvaliacaoAcademica.Domain.Model
{
   public class Turma
    {

       private Aluno _aluno;

       public virtual int Id { get; set; }
       public virtual string Descricao { get; set; }
       public virtual Modulo Modulo { get; set; }
       public virtual Professor Professor { get; set; }

       
    }
}
