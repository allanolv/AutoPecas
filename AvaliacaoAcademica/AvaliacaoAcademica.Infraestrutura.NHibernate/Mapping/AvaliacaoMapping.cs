using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
   public class AvaliacaoMapping : ClassMap<Avaliacao>
    {
       public AvaliacaoMapping()
       {
           Id(av => av.Id).GeneratedBy.Identity();
           Map(av => av.Codigo).Length(12).Not.Nullable();
           Map(av => av.Objetivo).Length(50).Not.Nullable();
           Map(av => av.DataInicio).Not.Nullable();
           Map(av => av.HoraInicio).Not.Nullable();
           Map(av => av.DataFim).Not.Nullable();
           Map(av => av.HoraFim).Not.Nullable();
       }
    }
}
