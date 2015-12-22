using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public abstract class AbstractRepository<T> : IRepository<T> where T : class
    {
        public ContextDeclaration Catalogue { get; set; }

        public IEnumerable<T> GetAll()
        {
            return Catalogue.Set<T>();

        }

        public T GetById(int id)
        {
            return Catalogue.Set<T>().Find(id);

        }

        public IEnumerable<T> GetByLambda(Func<T, bool> where)
        {
            return Catalogue.Set<T>().Where(where);
        }

        public T Insert(T entity)
        {
            Catalogue.Set<T>().Add(entity);
            return entity;
        }

        public void Remove(T entity)
        {
            Catalogue.Set<T>().Remove(entity);
        }

        public void Save()
        {
            Catalogue.SaveChanges();
        }
    }
}
