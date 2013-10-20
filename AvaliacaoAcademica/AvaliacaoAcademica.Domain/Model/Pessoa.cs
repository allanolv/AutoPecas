namespace AvaliacaoAcademica.Domain.Model
{
   public abstract class Pessoa
    {
       public virtual int ID { get; set; }
       public virtual string Nome { get; set; }
       public virtual Usuario Usuarios { get; set; }

    }
}
