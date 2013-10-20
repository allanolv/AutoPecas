using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
   public class ModuloMapping : ClassMap<Modulo>
    {
       public ModuloMapping()
       {
           Id(m => m.ID).GeneratedBy.Identity();
           Map(m => m.Descricao).Length(50).Not.Nullable();
           References(c => c.Curso);
       }
    }
}
