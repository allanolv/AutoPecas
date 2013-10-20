using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
   public class AlunoMapping : ClassMap<Aluno>
    {
       public AlunoMapping()
       {
           Id(a => a.ID).GeneratedBy.Identity();
           Map(a => a.Matricula).Not.Nullable();
           Map(a => a.Nome).Length(50).Not.Nullable();


       }
    }
}
