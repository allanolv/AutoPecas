using System;
using System.Linq;
using System.Linq.Expressions;
using AvaliacaoAcademica.Domain.Model;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Repository;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Implementation
{
    public class RespQuestao : IRepository<Questao>
    {
        readonly BaseDAL<Questao> _questao = new BaseDAL<Questao>(); 

        public Questao Salvar(Questao entity)
        {
            return _questao.Add(entity);
        }

        public Questao Atualizar(Questao entity)
        {
            return _questao.Update(entity);
        }

        public void Excluir(Questao entity)
        {
            _questao.Delete(entity);
        }

        public Questao BuscarPor(int id)
        {
            return _questao.FindBy(id);
        }

        public IQueryable<Questao> ObterTodos
        {
            get { return _questao.GetAll; }
        }

        public IQueryable<Questao> ObterTodosPor(Expression<Func<Questao, bool>> expression)
        {
            return ObterTodos.Where(expression);
        }

        public Questao FiltrandoPor(Expression<Func<Questao, bool>> expression)
        {
            return ObterTodosPor(expression).FirstOrDefault();
        }

    }
}
