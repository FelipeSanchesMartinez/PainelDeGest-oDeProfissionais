using PainelDeGestãoDeProfissionais.Aplication.Services.Interfaces;
using PainelDeGestãoDeProfissionais.Domain.Entities;
using PainelDeGestãoDeProfissionais.Infra.Repositories;

namespace PainelDeGestãoDeProfissionais.Aplication.Services
{
    public class ProfissionaisService : IProfissionaisService
    {
        private readonly IProfissionaisRepository _repository;

        public ProfissionaisService(IProfissionaisRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> AddProfissionalAsync(Profissional profissional) =>
            await _repository.AddAsync(profissional);

        public async Task<int> DeleteProfissionalAsync(Profissional profissional) =>
            await _repository.DeleteAsync(profissional);

        public async Task<int> UpdateProfissionalAsync(Profissional profissional) =>
            await _repository.UpdateAsync(profissional);

        public async Task<List<Profissional>> GetProfissionaisAsync() =>
            await _repository.GetAllAsync();

        public async Task<Profissional> GetProfissionaisByIdAsync(Profissional profissional) =>
            await _repository.FindByIdAsync(profissional.Id);
    }
}
