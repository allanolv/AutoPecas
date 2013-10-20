namespace AvaliacaoAcademica.Domain.Model
{
    public class Modulo
    {
        public virtual int ID { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Curso Curso { get; set; }

        //private Turma turma;
        //public Modulo(Turma _turma)
        //{
        //    this.turma = _turma;
        //}
    }
}
