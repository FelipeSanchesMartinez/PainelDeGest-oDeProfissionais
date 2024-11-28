using PainelDeGestãoDeProfissionais.Domain.Entities;

namespace PainelDeGestãoDeProfissionais.Aplication.Services.Interfaces
{
    public interface IProfissionaisService
    {
        Task<int> AddProfissionalAsync(Profissional profissional);
        Task<int> DeleteProfissionalAsync(Profissional profissional);
        Task<List<Profissional>> GetProfissionaisAsync();
        Task<int> UpdateProfissionalAsync(Profissional profissional);
        Task<Profissional> GetProfissionaisByIdAsync(Profissional profissional);
    }
}