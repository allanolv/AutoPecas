using System;
using System.Linq;
using System.Linq.Expressions;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Repository
{
   public interface IDAL<T>
    {
       T Add(T entity);
       T Update(T entity);
       void Delete(T entity);
       T FindBy(int id);
       IQueryable<T> GetAll { get; }
       T FindBy(Expression<Func<T, bool>> expression);
       IQueryable<T> FilterBy(Expression<Func<T, bool>> expression);
    }
}
