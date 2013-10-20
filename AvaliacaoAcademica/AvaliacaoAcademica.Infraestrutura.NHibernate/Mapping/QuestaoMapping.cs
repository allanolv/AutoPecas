using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
   public class QuestaoMapping : ClassMap<Questao>
    {
       public QuestaoMapping()
       {
           Id(q => q.Id).GeneratedBy.Identity();
           Map(q => q.Descricao).Length(100).Not.Nullable();
       }
    }
}
