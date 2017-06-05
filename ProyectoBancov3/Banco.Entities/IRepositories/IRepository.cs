using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //CREATES
        //Agrega un registro al repositorio (SQL Server) a la tabla Entity 
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        //READS
        TEntity Get(int? Id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        //U PDATES
        //void update(TEntity entity);
        //void UpdateRange(IEnumerable<TEntity> entities);
        // DELETES 
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

    }
}
