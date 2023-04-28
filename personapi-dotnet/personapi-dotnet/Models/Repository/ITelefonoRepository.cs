using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface ITelefonoRepository
    {
        Task<Persona> CreateTelefono(Telefono telefono, Persona persona);
        Task<bool> DeleteTelefono(Telefono telefono);
        Persona GetTelefono(int id);
        Task<bool> UpdatePersona(Telefono telefono);
        IEnumerable<Telefono> GetTelefono();
    }
}
