using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
  public class RespostaAvaliacaoMapping : ClassMap<RespostaAvaliacao>
    {
      public RespostaAvaliacaoMapping()
      {
          Id(ra => ra.Id).GeneratedBy.Identity();
          References(t => t.Turma);
          References(a => a.Aluno);
          References(av => av.Avaliacao);
          References(q => q.Questao);
          References(r => r.Respostas);
      }
    }
}
