using PainelDeGestãoDeProfissionais.Domain.Entities;
using PainelDeGestãoDeProfissionais.Infra.Interfaces;
using SQLite;
using System.Linq.Expressions;

namespace PainelDeGestãoDeProfissionais.Infra.Repositories
{
    public  class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity :Entity, new()
    {
        private readonly SQLiteAsyncConnection _dbConnection;

        public GenericRepository(SQLiteAsyncConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<int> AddAsync(TEntity entity) => await _dbConnection.InsertAsync(entity);
        public async Task<int> DeleteAsync(TEntity entity) => await _dbConnection.DeleteAsync(entity);
        public async Task<int> UpdateAsync(TEntity entity) => await _dbConnection.UpdateAsync(entity);
        public async Task<List<TEntity>> GetAllAsync() => await _dbConnection.Table<TEntity>().ToListAsync();
        public async Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate) =>
            await _dbConnection.Table<TEntity>().Where(predicate).ToListAsync();
        public async Task<TEntity?> FindByIdAsync(int id) =>
       await _dbConnection.Table<TEntity>().FirstOrDefaultAsync(entity => entity.Id == id);


    }
}

