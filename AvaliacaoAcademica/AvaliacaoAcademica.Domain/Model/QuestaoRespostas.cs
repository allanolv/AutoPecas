namespace AvaliacaoAcademica.Domain.Model
{
  public class QuestaoRespostas
    {
      public virtual int Id { get; set; }
      public virtual Questao Questao { get; set; }
      public virtual Respostas Respostas { get; set; }
    }
}
