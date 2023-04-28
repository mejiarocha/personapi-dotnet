using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public class PersonaRepository : IPersonaRepository
    {
        public Task<Persona> CreatePersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public Persona GetPersona(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persona> GetPersona()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePersona(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}
