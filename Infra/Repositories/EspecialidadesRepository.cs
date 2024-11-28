using PainelDeGestãoDeProfissionais.Domain.Entities;
using PainelDeGestãoDeProfissionais.Infra.Repositories;
using SQLite;

namespace PainelDeGestãoDeProfissionais.Infra.Repositories
{
    public class EspecialidadesRepository : GenericRepository<Especialidades>, IEspecialidadesRepository
    {
        public EspecialidadesRepository(SQLiteAsyncConnection dbConnection) : base(dbConnection)
        {
        }
    }
}
