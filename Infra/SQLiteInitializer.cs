using PainelDeGestãoDeProfissionais.Domain.Entities;
using SQLite;

namespace PainelDeGestãoDeProfissionais.Infra
{
    public class SQLiteInitializer
    {
        private readonly SQLiteAsyncConnection _dbConnection;

        public SQLiteInitializer(SQLiteAsyncConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task InitializeAsync()
        {
            await _dbConnection.CreateTableAsync<Profissional>();
            await _dbConnection.CreateTableAsync<Especialidades>();

            if (await _dbConnection.Table<Especialidades>().CountAsync() <= 0)
            {
                await InserirEspecialidades();
            }

        }
        private async Task InserirEspecialidades()
        {
            var especialidades = new List<Especialidades>
    {
        new Especialidades { Nome = "Cardiologia", TipoDocumento = "CRM" },
        new Especialidades { Nome = "Ortopedia", TipoDocumento = "CRM" },
        new Especialidades { Nome = "Pediatria", TipoDocumento = "CRM" },
        new Especialidades { Nome = "Dermatologia", TipoDocumento = "CRM" },
        new Especialidades { Nome = "Ginecologia", TipoDocumento = "CRM" },
        new Especialidades { Nome = "Neurologia", TipoDocumento = "CRM" },
        new Especialidades { Nome = "Psiquiatria", TipoDocumento = "CRM" },
        new Especialidades { Nome = "Anestesiologia", TipoDocumento = "CRM" },
        new Especialidades { Nome = "Radiologia", TipoDocumento = "CRM" },
        new Especialidades { Nome = "Endocrinologia", TipoDocumento = "CRM" },
        new Especialidades { Nome = "Nutricionista Clínico", TipoDocumento = "CRN" },
        new Especialidades { Nome = "Nutrição Esportiva", TipoDocumento = "CRN" },
        new Especialidades { Nome = "Nutrição Oncológica", TipoDocumento = "CRN" },
        new Especialidades { Nome = "Fisioterapia Ortopédica", TipoDocumento = "CREFITO" },
        new Especialidades { Nome = "Fisioterapia Neurológica", TipoDocumento = "CREFITO" },
        new Especialidades { Nome = "Fisioterapia Respiratória", TipoDocumento = "CREFITO" },
        new Especialidades { Nome = "Ortodontia", TipoDocumento = "CRO" },
        new Especialidades { Nome = "Implantodontia", TipoDocumento = "CRO" },
        new Especialidades { Nome = "Endodontia", TipoDocumento = "CRO" },
        new Especialidades { Nome = "Enfermagem Geral", TipoDocumento = "COREN" },
        new Especialidades { Nome = "Enfermagem Obstétrica", TipoDocumento = "COREN" },
        new Especialidades { Nome = "Psicologia Clínica", TipoDocumento = "CRP" },
        new Especialidades { Nome = "Psicologia Organizacional", TipoDocumento = "CRP" },
        new Especialidades { Nome = "Neuropsicologia", TipoDocumento = "CRP" },
        new Especialidades { Nome = "Farmácia Clínica", TipoDocumento = "CRF" },
        new Especialidades { Nome = "Farmácia Hospitalar", TipoDocumento = "CRF" },
        new Especialidades { Nome = "Análises Clínicas", TipoDocumento = "CRF" },
        new Especialidades { Nome = "Personal Trainer", TipoDocumento = "CREF" },
        new Especialidades { Nome = "Preparação Física", TipoDocumento = "CREF" }
    };

            await _dbConnection.InsertAllAsync(especialidades);
        }

    }
}
