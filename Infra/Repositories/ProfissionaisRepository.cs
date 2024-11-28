using PainelDeGestãoDeProfissionais.Domain.Entities;
using SQLite;
using System.Data;
using System.Data.Common;

namespace PainelDeGestãoDeProfissionais.Infra.Repositories
{
    public class ProfissionaisRepository : GenericRepository<Profissional>, IProfissionaisRepository
    {
        public ProfissionaisRepository(SQLiteAsyncConnection dbConnection) : base(dbConnection)
        {
        }
    }
}