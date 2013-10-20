using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
  public class AvaliacaoQuestoesMapping : ClassMap<AvaliacaoQuestoes>
    {
      public AvaliacaoQuestoesMapping()
      {
          Id(aq => aq.Id).GeneratedBy.Identity();
          References(aq => aq.Avaliacao);
          References(aq => aq.Questao);
      }
    }
}
