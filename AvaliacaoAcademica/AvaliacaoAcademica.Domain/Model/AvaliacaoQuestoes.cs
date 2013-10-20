namespace AvaliacaoAcademica.Domain.Model
{
 public class AvaliacaoQuestoes
    {
     public virtual int Id { get; set; }
     public virtual Avaliacao Avaliacao { get; set; }
     public virtual Questao Questao { get; set; }
    }
}
