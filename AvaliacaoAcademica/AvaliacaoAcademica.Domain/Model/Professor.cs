using System;
namespace AvaliacaoAcademica.Domain.Model
{
  public class Professor : Pessoa
    {
      public virtual int Matricula { get; set; }
      public virtual DateTime DtAdmissao { get; set; }
      public virtual DateTime DtDemissao { get; set; }
    }
}
