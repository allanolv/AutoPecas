using System;
using System.Linq;
using System.Linq.Expressions;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Repository
{
   public interface IRepository<T>
    {
        T Salvar(T entity);
        T Atualizar(T entity);
        void Excluir(T entity);
        T BuscarPor(int id);
        IQueryable<T> ObterTodos { get; }
        T FiltrandoPor(Expression<Func<T, bool>> expression);
        IQueryable<T> ObterTodosPor(Expression<Func<T, bool>> expression);

    }
}
