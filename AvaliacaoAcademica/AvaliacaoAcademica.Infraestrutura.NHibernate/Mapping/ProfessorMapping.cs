using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
  public class ProfessorMapping : ClassMap<Professor>
    {
      public ProfessorMapping()
      {
          Id(p => p.ID).GeneratedBy.Identity();
          Map(p => p.Matricula).Not.Nullable();
          Map(p => p.Nome).Length(50).Not.Nullable();
      }
    }
}
