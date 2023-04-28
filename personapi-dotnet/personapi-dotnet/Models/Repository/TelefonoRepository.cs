using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public class TelefonoRepository : ITelefonoRepository
    {
        public Task<Persona> CreateTelefono(Telefono telefono)
        {
            throw new NotImplementedException();
        }

        public Task<Persona> CreateTelefono(Telefono telefono, Persona persona)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTelefono(Telefono telefono)
        {
            throw new NotImplementedException();
        }

        public Persona GetTelefono(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Telefono> GetTelefono()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePersona(Telefono telefono)
        {
            throw new NotImplementedException();
        }
    }
}
