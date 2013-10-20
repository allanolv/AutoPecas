using System;
using System.Linq;
using System.Linq.Expressions;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Builder;
using AvaliacaoAcademica.Infraestrutura.NHibernate.Repository;
using NHibernate;

namespace AvaliacaoAcademica.Infraestrutura.NHibernate.Implementation
{

    public class BaseDAL<T> : IDAL<T>
    {
        HybridSessionBuilder _builder = new HybridSessionBuilder();
        private ITransaction _transaction;

        private ISession _session;
        public virtual ISession Session
        {
            get
            {
                if (_builder == null)
                    _builder = new HybridSessionBuilder();

                return _session ?? (_session = _builder.GetSession());
            }
        }


        public T Add(T entity)
        {
            try
            {
                _transaction = Session.BeginTransaction();
                Session.Save(entity);
                Session.Flush();
                _transaction.Commit();
                _transaction.Dispose();
                return entity;
            }
            catch (Exception ex)
            {
                if (_transaction != null)
                    _transaction.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public T Update(T entity)
        {
            try
            {
                _transaction = _session.BeginTransaction();
                Session.Update(entity);
                Session.Flush();
                _transaction.Commit();
                _transaction.Dispose();
                return entity;
            }
            catch (Exception ex)
            {
                if (_transaction != null)
                    _transaction.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public void Delete(T entity)
        {
            try
            {
                _transaction = _session.BeginTransaction();
                Session.Delete(entity);
                Session.Flush();
                _transaction.Commit();
                _transaction.Dispose();

            }
            catch (Exception ex)
            {
                if (_transaction != null)
                    _transaction.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public T FindBy(int id)
        {
            try
            {

                return Session.Get<T>(id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IQueryable<T> GetAll
        {
            get { return Session.CreateCriteria(typeof(T)).List<T>().AsQueryable(); }
        }

        public T FindBy(Expression<Func<T, bool>> expression)
        {
            return FilterBy(expression).FirstOrDefault();
        }

        public IQueryable<T> FilterBy(Expression<Func<T, bool>> expression)
        {
            return GetAll.Where(expression).AsQueryable();
        }
    }
}
