using System;
using System.Linq;
using System.Linq.Expressions;
using AvaliacaoAcademica.Domain.Model;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Repository;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Implementation
{

    public class RespResposta : IRepository<Respostas>
    {
        readonly BaseDAL<Respostas> _respostas = new BaseDAL<Respostas>();


        public Respostas Salvar(Respostas entity)
        {
            return _respostas.Add(entity);
        }

        public Respostas Atualizar(Respostas entity)
        {
            return _respostas.Update(entity);
        }

        public void Excluir(Respostas entity)
        {
             _respostas.Delete(entity);
        }

        public Respostas BuscarPor(int id)
        {
            return _respostas.FindBy(id);
        }

        public IQueryable<Respostas> ObterTodos
        {
            get { return _respostas.GetAll; }
        }


        public IQueryable<Respostas> ObterTodosPor(Expression<Func<Respostas, bool>> expression)
        {
            return ObterTodos.Where(expression);
        }


        public Respostas FiltrandoPor(Expression<Func<Respostas, bool>> expression)
        {
            return ObterTodosPor(expression).FirstOrDefault();
        }
    }
}
