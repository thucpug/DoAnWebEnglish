using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace English.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        // Marks an entity as new
        T Add(T entity);

        // Marks an entity as modified
        void Update(T entity);

        // Marks an entity to be removed
        T Delete(T entity);

        //Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);
        T Delete(int id);

        T GetSingleById(int id);

        IEnumerable<T> GetAll(string[] includes = null);

    }
}
