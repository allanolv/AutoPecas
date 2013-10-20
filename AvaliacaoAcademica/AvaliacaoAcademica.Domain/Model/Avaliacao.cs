using System;
namespace AvaliacaoAcademica.Domain.Model
{
   public class Avaliacao
    {
        public virtual int Id { get; set; }
        public virtual int Codigo { get; set; }
        public virtual string Objetivo { get; set; }
        public virtual DateTime DataInicio { get; set; }
        public virtual DateTime HoraInicio { get; set; }
        public virtual DateTime DataFim { get; set; }
        public virtual DateTime HoraFim { get; set; }
        public virtual Turma Turmas { get; set; }
        public virtual Questao Questoes { get; set; }
    }  
}      
       
       
       