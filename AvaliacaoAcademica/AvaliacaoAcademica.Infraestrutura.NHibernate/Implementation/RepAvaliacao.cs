using System;
using System.Linq;
using System.Linq.Expressions;
using AvaliacaoAcademica.Domain.Model;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Repository;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Implementation
{
  public class RepAvaliacao : IRepository<Avaliacao>
    {
      readonly BaseDAL<Avaliacao> _avaliacao = new BaseDAL<Avaliacao>(); 

        public Avaliacao Salvar(Avaliacao entity)
        {
            return _avaliacao.Add(entity);
        }

        public Avaliacao Atualizar(Avaliacao entity)
        {
            return _avaliacao.Update(entity);
        }

        public void Excluir(Avaliacao entity)
        {
            _avaliacao.Delete(entity);
        }

        public Avaliacao BuscarPor(int id)
        {
           return _avaliacao.FindBy(id);
        }

        public IQueryable<Avaliacao> ObterTodos
        {
            get { return _avaliacao.GetAll; }
        }


        public IQueryable<Avaliacao> ObterTodosPor(Expression<Func<Avaliacao, bool>> expression)
        {
            return ObterTodos.Where(expression);
        }


        public Avaliacao FiltrandoPor(Expression<Func<Avaliacao, bool>> expression)
        {
            return ObterTodosPor(expression).FirstOrDefault();
        }
    }
}
