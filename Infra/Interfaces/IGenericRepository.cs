using System.Linq.Expressions;

namespace PainelDeGestãoDeProfissionais.Infra.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : new()
    {
        Task<int> AddAsync(TEntity entity);
        Task<int> DeleteAsync(TEntity entity);
        Task<int> UpdateAsync(TEntity entity);
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity?> FindByIdAsync(int id);
    }
}
