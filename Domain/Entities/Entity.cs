using SQLite;

namespace PainelDeGestãoDeProfissionais.Domain.Entities
{
    public abstract class Entity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}
