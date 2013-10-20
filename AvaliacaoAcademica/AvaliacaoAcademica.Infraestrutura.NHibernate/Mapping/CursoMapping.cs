using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
   public class CursoMapping : ClassMap<Curso>
    {
       public CursoMapping()
       {
           Id(c => c.ID).GeneratedBy.Identity();
           Map(c => c.Descricao).Length(50).Not.Nullable();
       }
    }
}
