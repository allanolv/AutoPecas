namespace AvaliacaoAcademica.Domain.Model
{
    public class RespostaAvaliacao
    {
        public virtual int Id { get; set; }
        public virtual Turma Turma { get; set; }
        public virtual Aluno Aluno { get; set; }
        public virtual Avaliacao Avaliacao { get; set; }
        public virtual Questao Questao { get; set; }
        public virtual Respostas Respostas { get; set; }
    }
}
