using RegistanFerghanaLC.Domain.Common;
using System.Linq.Expressions;

namespace RegistanFerghanaLC.DataAccess.Interfaces.Common
{
    public interface IGenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        public IQueryable<T> GetAll();

        public IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}
