using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface IPersonaRepository
    {
        Task<Persona> CreatePersona(Persona persona);
        Task<bool> DeletePersona(Persona persona);
        Persona GetPersona(int id);
        Task<bool> UpdatePersona(Persona persona);
        IEnumerable<Persona> GetPersona();
    }
}
