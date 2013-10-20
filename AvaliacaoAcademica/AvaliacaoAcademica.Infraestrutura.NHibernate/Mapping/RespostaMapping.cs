using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
   public class RespostaMapping : ClassMap<Respostas>
    {
       public RespostaMapping()
       {
           Id(r => r.ID).GeneratedBy.Identity();
           Map(r => r.Descricao).Length(50).Not.Nullable();
       }
    }
}
