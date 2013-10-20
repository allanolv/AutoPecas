using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
   public class TurmaMapping : ClassMap<Turma>
    {
       public TurmaMapping()
       {
           Id(t => t.Id).GeneratedBy.Identity();
           References(m => m.Modulo).Not.Nullable();
           References(p => p.Professor).Not.Nullable();
       }
    }
}
