using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface IProfesionRepository
    {
        Task<Profesion> CreateProfesion(Profesion profesion);
        Task<bool> DeleteProfesion(Profesion profesion);
        Profesion GetProfesion(int id);
        

    }
}


