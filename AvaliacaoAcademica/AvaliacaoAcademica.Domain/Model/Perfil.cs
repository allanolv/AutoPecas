namespace AvaliacaoAcademica.Domain.Model
{
   public class Perfil
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual Usuario Usuarios { get; set; }
    }
}
