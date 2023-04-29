using personapi_dotnet.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace personapi_dotnet.Models.Repository
{
    public class ProfesionRepository : IProfesionRepository
    {
        protected readonly PersonaDbContext _context;

        public ProfesionRepository(PersonaDbContext context)
        {
            _context = context;
        }

        public async Task<Profesion> CreateProfesion(Profesion profesion)
        {
            await _context.Set<Profesion>().AddAsync(profesion);
            await _context.SaveChangesAsync();
            return profesion;
        }

        public IEnumerable<Profesion> GetProfesions()
        {
            return _context.Profesions.ToList();
        }

        public async Task<bool> DeleteProfesion(Profesion profesion)
        {
            if (profesion == null)
            {
                return false;
            }
            _context.Set<Profesion>().Remove(profesion);
            await _context.SaveChangesAsync();
            return true;
        }

        public Profesion GetProfesion(int id)
        {
            return _context.Profesions.Find(id);
        }
    }
}
