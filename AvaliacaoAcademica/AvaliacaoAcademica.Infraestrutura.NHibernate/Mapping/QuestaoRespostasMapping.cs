using AvaliacaoAcademica.Domain.Model;
using FluentNHibernate.Mapping;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Mapping
{
   public class QuestaoRespostasMapping : ClassMap<QuestaoRespostas>
    {
       public QuestaoRespostasMapping()
       {
           Id(qr => qr.Id).GeneratedBy.Identity();
           References(qr => qr.Questao);
           References(qr => qr.Respostas);
       }
    }
}
