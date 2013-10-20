using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
   public class AlunoTurmaMapping : ClassMap<AlunoTurma>
    {
       public AlunoTurmaMapping()
       {
           Id(at => at.Id).GeneratedBy.Identity();
           References(a => a.Aluno);
           References(t => t.Turma);
       }
    }
}
