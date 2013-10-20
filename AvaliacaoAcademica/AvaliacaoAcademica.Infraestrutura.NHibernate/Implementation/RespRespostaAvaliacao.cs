using System;
using System.Linq;
using System.Linq.Expressions;
using AvaliacaoAcademica.Domain.Model;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Repository;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Implementation
{
    public class RespRespostaAvaliacao : IRepository<RespostaAvaliacao>
    {
        readonly BaseDAL<RespostaAvaliacao> _respavaliacao = new BaseDAL<RespostaAvaliacao>();
 
        public RespostaAvaliacao Salvar(RespostaAvaliacao entity)
        {
            return _respavaliacao.Add(entity);
        }

        public RespostaAvaliacao Atualizar(RespostaAvaliacao entity)
        {
            return _respavaliacao.Update(entity);
        }

        public void Excluir(RespostaAvaliacao entity)
        {
           _respavaliacao.Delete(entity);
        }

        public RespostaAvaliacao BuscarPor(int id)
        {
            return _respavaliacao.FindBy(id);
        }

        public IQueryable<RespostaAvaliacao> ObterTodos
        {
            get { return _respavaliacao.GetAll; }
        }


        public IQueryable<RespostaAvaliacao> ObterTodosPor(Expression<Func<RespostaAvaliacao, bool>> expression)
        {
            throw new System.NotImplementedException();
        }


        public RespostaAvaliacao FiltrandoPor(Expression<Func<RespostaAvaliacao, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
